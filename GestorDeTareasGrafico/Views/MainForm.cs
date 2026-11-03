using GestorDeTareas.Controllers;
using GestorDeTareas.Models;

namespace GestorDeTareas.Views;

public partial class MainForm : Form
{
    private readonly TaskItemController controller;
    private Guid? selectedId;

    public MainForm(TaskItemController controller)
    {
        this.controller = controller;
        InitializeComponent();

        // Dispara SelectedIndexChanged -> RefreshList()
        cmbFilter.SelectedIndex = 0;
    }

    // ---------- Carga de datos ----------

    private void RefreshList()
    {
        var keep = selectedId;
        var filter = (TaskFilter)cmbFilter.SelectedIndex;
        var tasks = controller.ListTasks(filter);

        dgvTasks.Rows.Clear();
        foreach (var task in tasks)
        {
            int i = dgvTasks.Rows.Add(task.Name, task.Description, task.Status ? "Completada" : "Pendiente");
            dgvTasks.Rows[i].Tag = task.Id;
            if (task.Status)
                dgvTasks.Rows[i].DefaultCellStyle.ForeColor = Color.Gray;
        }

        // Al rellenar, el grid selecciona la primera fila: se limpia y se
        // restaura la selección anterior (si la tarea sigue visible).
        dgvTasks.ClearSelection();
        if (keep != null)
        {
            foreach (DataGridViewRow row in dgvTasks.Rows)
            {
                if ((Guid)row.Tag == keep.Value)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        lblCount.Text = $"{tasks.Count} tarea(s)";
    }

    private void ClearEditor()
    {
        selectedId = null;
        txtName.Clear();
        txtDescription.Clear();
        chkCompleted.Checked = false;
        btnToggle.Text = "Marcar como completada";
        UpdateButtons();
    }

    private void UpdateButtons()
    {
        bool hasSelection = selectedId != null;
        btnModify.Enabled = hasSelection;
        btnDelete.Enabled = hasSelection;
        btnToggle.Enabled = hasSelection;
    }

    // ---------- Eventos ----------

    private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        RefreshList();
    }

    private void dgvTasks_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvTasks.SelectedRows.Count == 0)
        {
            ClearEditor();
            return;
        }

        selectedId = (Guid)dgvTasks.SelectedRows[0].Tag;
        var task = controller.GetTask(selectedId.Value);
        if (task == null) return;

        txtName.Text = task.Name;
        txtDescription.Text = task.Description;
        chkCompleted.Checked = task.Status;
        btnToggle.Text = task.Status ? "Marcar como pendiente" : "Marcar como completada";
        UpdateButtons();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            controller.AddTask(txtName.Text, txtDescription.Text, chkCompleted.Checked);
            selectedId = null;
            RefreshList();
            ClearEditor();
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Datos no válidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtName.Focus();
        }
    }

    private void btnModify_Click(object sender, EventArgs e)
    {
        if (selectedId == null) return;

        try
        {
            controller.UpdateTask(selectedId.Value, txtName.Text, txtDescription.Text, chkCompleted.Checked);
            RefreshList();
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Datos no válidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtName.Focus();
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (selectedId == null) return;

        var result = MessageBox.Show("¿Seguro que quieres eliminar la tarea seleccionada?",
            "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result != DialogResult.Yes) return;

        controller.DeleteTask(selectedId.Value);
        selectedId = null;
        RefreshList();
        ClearEditor();
    }

    private void btnToggle_Click(object sender, EventArgs e)
    {
        if (selectedId == null) return;

        var task = controller.GetTask(selectedId.Value);
        if (task == null) return;

        controller.SetTaskStatus(selectedId.Value, !task.Status);
        RefreshList();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        dgvTasks.ClearSelection();
        ClearEditor();
        txtName.Focus();
    }
}

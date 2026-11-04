using GestorDeTareasGrafico.Controllers;
using GestorDeTareasGrafico.Models;
using GestorDeTareasGrafico.Repositories;

namespace GestorDeTareasGrafico;

public partial class Form1 : Form
{
    private readonly TaskItemController controller =
        new(new TaskItemRepository());

    // Controles
    private readonly ListView lvTareas = new();
    private readonly TextBox txtNombre = new();
    private readonly TextBox txtDescripcion = new();
    private readonly CheckBox chkCompletada = new();
    private readonly Button btnAnadir = new();
    private readonly Button btnModificar = new();
    private readonly Button btnEliminar = new();

    public Form1()
    {
        InitializeComponent();
        BuildUi();
        btnModificar.Enabled = false;
        btnEliminar.Enabled = false;
        RefreshList();
    }

    // ---------- Construcción de la interfaz ----------
    private void BuildUi()
    {
        Text = "Gestor de tareas";
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(820, 460);
        MinimumSize = new Size(700, 420);

        // Lista de tareas
        lvTareas.Dock = DockStyle.Fill;
        lvTareas.View = View.Details;
        lvTareas.FullRowSelect = true;
        lvTareas.MultiSelect = false;
        lvTareas.HideSelection = false;
        lvTareas.GridLines = true;
        lvTareas.Columns.Add("Nombre", 150);
        lvTareas.Columns.Add("Descripción", 220);
        lvTareas.Columns.Add("Estado", 90);
        lvTareas.SelectedIndexChanged += lvTareas_SelectedIndexChanged;

        // Campos de edición
        txtNombre.Dock = DockStyle.Fill;
        txtDescripcion.Dock = DockStyle.Fill;
        txtDescripcion.Multiline = true;
        txtDescripcion.ScrollBars = ScrollBars.Vertical;
        chkCompletada.Text = "Completada";
        chkCompletada.AutoSize = true;

        // Botones
        btnAnadir.Text = "Añadir";
        btnModificar.Text = "Modificar";
        btnEliminar.Text = "Eliminar";
        foreach (var b in new[] { btnAnadir, btnModificar, btnEliminar })
            b.Size = new Size(90, 30);
        btnAnadir.Click += btnAnadir_Click;
        btnModificar.Click += btnModificar_Click;
        btnEliminar.Click += btnEliminar_Click;
        AcceptButton = btnAnadir;

        var panelBotones = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            AutoSize = true
        };
        panelBotones.Controls.AddRange(new Control[] { btnAnadir, btnModificar, btnEliminar });

        // Panel derecho: una columna, una fila por elemento
        var panelDerecho = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 6,
            Padding = new Padding(10, 0, 0, 0)
        };
        panelDerecho.RowStyles.Add(new RowStyle(SizeType.AutoSize));          // label nombre
        panelDerecho.RowStyles.Add(new RowStyle(SizeType.AutoSize));          // txtNombre
        panelDerecho.RowStyles.Add(new RowStyle(SizeType.AutoSize));          // label descripción
        panelDerecho.RowStyles.Add(new RowStyle(SizeType.Percent, 100));      // txtDescripcion
        panelDerecho.RowStyles.Add(new RowStyle(SizeType.AutoSize));          // checkbox
        panelDerecho.RowStyles.Add(new RowStyle(SizeType.AutoSize));          // botones
        panelDerecho.Controls.Add(new Label { Text = "Nombre:", AutoSize = true }, 0, 0);
        panelDerecho.Controls.Add(txtNombre, 0, 1);
        panelDerecho.Controls.Add(new Label { Text = "Descripción:", AutoSize = true }, 0, 2);
        panelDerecho.Controls.Add(txtDescripcion, 0, 3);
        panelDerecho.Controls.Add(chkCompletada, 0, 4);
        panelDerecho.Controls.Add(panelBotones, 0, 5);

        // Contenedor principal: lista (60%) | panel de edición (40%)
        var principal = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 2,
            Padding = new Padding(10)
        };
        principal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));
        principal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
        principal.Controls.Add(lvTareas, 0, 0);
        principal.Controls.Add(panelDerecho, 1, 0);

        Controls.Add(principal);
    }

    // ---------- Utilidades ----------
    private void RefreshList()
    {
        lvTareas.Items.Clear();
        foreach (var t in controller.ListTasks())
        {
            var item = new ListViewItem(t.Name);
            item.SubItems.Add(t.Description);
            item.SubItems.Add(t.Status ? "Completada" : "Pendiente");
            item.Tag = t;
            lvTareas.Items.Add(item);
        }
    }

    private void ClearForm()
    {
        txtNombre.Clear();
        txtDescripcion.Clear();
        chkCompletada.Checked = false;
        lvTareas.SelectedItems.Clear();
        txtNombre.Focus();
    }

    // ---------- Eventos ----------
    private void lvTareas_SelectedIndexChanged(object? sender, EventArgs e)
    {
        bool haySeleccion = lvTareas.SelectedItems.Count > 0;
        btnModificar.Enabled = haySeleccion;
        btnEliminar.Enabled = haySeleccion;

        if (haySeleccion)
        {
            var tarea = (TaskItem)lvTareas.SelectedItems[0].Tag!;
            txtNombre.Text = tarea.Name;
            txtDescripcion.Text = tarea.Description;
            chkCompletada.Checked = tarea.Status;
        }
    }

    private void btnAnadir_Click(object? sender, EventArgs e)
    {
        string nombre = txtNombre.Text.Trim();

        if (string.IsNullOrWhiteSpace(nombre))
        {
            MessageBox.Show("El nombre es obligatorio.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (controller.TaskExists(nombre))
        {
            MessageBox.Show("Ya existe una tarea con ese nombre.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        controller.AddTask(nombre, txtDescripcion.Text, chkCompletada.Checked);
        RefreshList();
        ClearForm();
    }

    private void btnModificar_Click(object? sender, EventArgs e)
    {
        var tarea = (TaskItem)lvTareas.SelectedItems[0].Tag!;
        string nombreOriginal = tarea.Name;
        string nuevoNombre = txtNombre.Text.Trim();

        if (string.IsNullOrWhiteSpace(nuevoNombre))
        {
            MessageBox.Show("El nombre es obligatorio.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (nuevoNombre != nombreOriginal && controller.TaskExists(nuevoNombre))
        {
            MessageBox.Show("Ya existe una tarea con ese nombre.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // El nombre se cambia el último porque las demás operaciones buscan por el nombre original
        controller.ModifyTaskDescription(nombreOriginal, txtDescripcion.Text);
        controller.ModifyTaskStatus(nombreOriginal, chkCompletada.Checked);
        controller.ModifyTaskName(nombreOriginal, nuevoNombre);

        RefreshList();
        ClearForm();
    }

    private void btnEliminar_Click(object? sender, EventArgs e)
    {
        var tarea = (TaskItem)lvTareas.SelectedItems[0].Tag!;

        var respuesta = MessageBox.Show(
            $"¿Eliminar la tarea \"{tarea.Name}\"?", "Confirmar",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (respuesta == DialogResult.Yes)
        {
            controller.DeleteTask(tarea);
            RefreshList();
            ClearForm();
        }
    }
}
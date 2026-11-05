using GestorDeTareasGrafico.Controllers;
using GestorDeTareasGrafico.Models;
using GestorDeTareasGrafico.Repositories;

namespace GestorDeTareasGrafico;

public partial class Form1 : Form
{
    private readonly TaskItemController controller;
    private TaskItem? selectedTask;

    public Form1()
    {
        InitializeComponent();
        var repository = new TaskItemRepository();
        controller = new TaskItemController(repository);
        ConfigureListView();
        LoadTasks();
        btnAdd.Click += btnAdd_Click;
        lvTasks.SelectedIndexChanged += lvTasks_SelectedIndexChanged;
        btnModify.Click += btnModify_Click;
        btnDelete.Click += btnDelete_Click;
    }

    private void ConfigureListView()
    {
        lvTasks.FullRowSelect = true;
        lvTasks.GridLines = true;
        lvTasks.MultiSelect = false;
        lvTasks.HideSelection = false;
        lvTasks.Columns[0].Width = 100;
        lvTasks.Columns[1].Width = 180;
        lvTasks.Columns[2].Width = 90;
    }

    private void LoadTasks()
    {
        lvTasks.Items.Clear();
        string selectedFilter = cmbFilter.SelectedItem?.ToString() ?? "Todas";
        foreach (var task in controller.ListTasks())
        {
            bool showTask = selectedFilter switch
            {
                "Pendientes" => !task.Status,
                "Completadas" => task.Status,
                _ => true
            };
            if (!showTask)
            {
                continue;
            }

            string status = task.Status
                ? "Completada"
                : "Pendiente";
            var item = new ListViewItem(task.Name);
            item.SubItems.Add(task.Description);
            item.SubItems.Add(status);
            item.Tag = task;
            lvTasks.Items.Add(item);
        }
    }

    private void btnAdd_Click(object? sender, EventArgs e)
    {
        string name = txtName.Text.Trim();
        string description = txtDescription.Text.Trim();
        if (string.IsNullOrWhiteSpace(name))
        {
            MessageBox.Show(
                "Debes introducir un nombre para la tarea.",
                "Datos incorrectos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        if (controller.TaskExists(name))
        {
            MessageBox.Show(
                "Ya existe una tarea con ese nombre.",
                "Datos incorrectos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        controller.AddTask(
            name,
            description,
            chkCompleted.Checked);
        LoadTasks();
        ClearFields();
        MessageBox.Show(
            "Tarea añadida correctamente.",
            "Información",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void ClearFields()
    {
        txtName.Clear();
        txtDescription.Clear();
        chkCompleted.Checked = false;
        selectedTask = null;
        lvTasks.SelectedItems.Clear();
    }

    private void lvTasks_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (lvTasks.SelectedItems.Count == 0)
        {
            selectedTask = null;
            return;
        }

        var selectedItem = lvTasks.SelectedItems[0];
        selectedTask = selectedItem.Tag as TaskItem;
        if (selectedTask == null)
        {
            return;
        }

        txtName.Text = selectedTask.Name;
        txtDescription.Text = selectedTask.Description;
        chkCompleted.Checked = selectedTask.Status;
    }

    private void btnModify_Click(object? sender, EventArgs e)
    {
        if (selectedTask == null)
        {
            MessageBox.Show(
                "Selecciona una tarea para modificar.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        string newName = txtName.Text.Trim();
        string newDescription = txtDescription.Text.Trim();
        if (string.IsNullOrWhiteSpace(newName))
        {
            MessageBox.Show(
                "El nombre no puede estar vacío.",
                "Datos incorrectos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        if (newName != selectedTask.Name &&
            controller.TaskExists(newName))
        {
            MessageBox.Show(
                "Ya existe otra tarea con ese nombre.",
                "Datos incorrectos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        string oldName = selectedTask.Name;
        controller.ModifyTaskName(oldName, newName);
        controller.ModifyTaskDescription(newName, newDescription);
        controller.ModifyTaskStatus(newName, chkCompleted.Checked);
        LoadTasks();
        ClearFields();
        MessageBox.Show(
            "Tarea modificada correctamente.",
            "Información",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void btnDelete_Click(object? sender, EventArgs e)
    {
        if (selectedTask == null)
        {
            MessageBox.Show(
                "Selecciona una tarea para eliminar.",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        DialogResult result = MessageBox.Show(
            "¿Seguro que quieres eliminar la tarea seleccionada?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
        if (result != DialogResult.Yes)
        {
            return;
        }

        controller.DeleteTask(selectedTask);
        LoadTasks();
        ClearFields();
        MessageBox.Show(
            "Tarea eliminada correctamente.",
            "Información",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadTasks();
        ClearFields();
    }
}
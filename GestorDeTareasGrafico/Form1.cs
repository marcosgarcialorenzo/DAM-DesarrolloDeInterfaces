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

        foreach (var task in controller.ListTasks())
        {
            string status = task.Status
                ? "Completada"
                : "Pendiente";

            var item = new ListViewItem(task.Name);
            item.SubItems.Add(task.Description);
            item.SubItems.Add(status);

            // Guardamos el objeto asociado a la fila
            item.Tag = task;

            lvTasks.Items.Add(item);
        }
    }
}
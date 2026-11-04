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
        
        // Form1
        //     ↓
        // TaskItemController
        //     ↓
        // TaskItemRepository
        //     ↓
        // List<TaskItem>
    }
}
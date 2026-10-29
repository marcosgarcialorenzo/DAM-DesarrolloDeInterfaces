using GestorDeTareasGrafico.Controllers;
using GestorDeTareasGrafico.Repositories;
using GestorDeTareasGrafico.Views;

namespace GestorDeTareasGrafico;

static class Program
{
    [STAThread]
    static void Main()
    {
        TaskItemRepository taskRepository = new TaskItemRepository();
        TaskItemController taskItemController = new TaskItemController(taskRepository);
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}
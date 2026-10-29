using GestorDeTareasGrafico.Controllers;
using GestorDeTareasGrafico.Repositories;
using GestorDeTareasGrafico.Views;

namespace GestorDeTareasGrafico;

static class Program
{
    [STAThread]
    static void Main()
    {
        TaskItemView taskItemView = new TaskItemView();
        TaskItemRepository taskRepository = new TaskItemRepository();
        TaskItemController taskItemController = new TaskItemController(taskRepository);
        taskItemView.Menu(taskItemController);
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}
using GestorDeTareas.Controllers;
using GestorDeTareas.Repositories;
using GestorDeTareas.Views;

internal class Program
{
    public static void Main(string[] args)
    {
       TaskView taskView = new TaskView();
       TaskItemRepository taskRepository = new TaskItemRepository();
       TaskController taskController = new TaskController(taskRepository);
       taskView.Menu(taskController);
    }
}
using GestorDeTareas.Controllers;
using GestorDeTareas.Repositories;
using GestorDeTareas.Views;

internal class Program
{
    public static void Main(string[] args)
    {
       TaskItemView taskItemView = new TaskItemView();
       TaskItemRepository taskRepository = new TaskItemRepository();
       TaskItemController taskItemController = new TaskItemController(taskRepository);
       taskItemView.Menu(taskItemController);
    }
}
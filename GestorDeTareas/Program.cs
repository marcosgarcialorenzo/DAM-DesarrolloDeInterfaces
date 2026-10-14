using ConsoleApp2.Controllers;
using ConsoleApp2.Repositories;
using ConsoleApp2.Views;

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
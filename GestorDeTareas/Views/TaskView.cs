using ConsoleApp2.Controllers;

namespace ConsoleApp2.Views;

public class TaskView
{
    public void Menu(TaskController controller)
    {
        var option = 0;
        while (option != 10)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Añadir tareas");
            Console.WriteLine("2. Consultar tareas");
            Console.WriteLine("3. Modificar nombre tarea");
            Console.WriteLine("4. Modificar descripción tarea");
            Console.WriteLine("5. Modificar estado tarea");
            Console.WriteLine("6. Eliminar tareas");

            Console.Write("Opción: ");

            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Nombre: ");
                    string name = Console.ReadLine();
                    Console.Write("Descripción: ");
                    string description = Console.ReadLine();
                    controller.AddTask(name, description);
                    break;
                case 2:
                    Console.Write("Nombre: ");
                    name = Console.ReadLine();
                    controller.GetTask(name);
                    break;
                case 3:
                    Console.Write("Nombre: ");
                    name = Console.ReadLine();
                    Console.Write("Nuevo nombre: ");
                    string newName = Console.ReadLine();
                    controller.ModifyTaskName(name, newName);
                    break;
                case 4:
                    Console.Write("Nombre: ");
                    name = Console.ReadLine();
                    Console.Write("Nueva descripcion: ");
                    string newDescription = Console.ReadLine();
                    controller.ModifyTaskDescription(name, newDescription);
                    break;
                case 5:
                    Console.Write("Nombre: ");
                    name = Console.ReadLine();
                    Console.Write("Nuevo estado (Pendiente, Completada): ");
                    string newstatus = Console.ReadLine();
                    bool newStatusBool = newstatus == "Completada" ? true : false;
                    newStatusBool = newstatus == "Pendiente" ? false : false;
                    controller.ModifyTaskStatus(name, newStatusBool);
                    break;
                case 6:
                    Console.Write("Nombre: ");
                    name = Console.ReadLine();
                    var task = controller.GetTask(name);
                    controller.DeleteTask(task);
                    break;
                case 10:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
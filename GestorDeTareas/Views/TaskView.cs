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
            Console.WriteLine("2. Listar tareas");
            Console.WriteLine("3. Consultar tarea");
            Console.WriteLine("4. Modificar nombre tarea");
            Console.WriteLine("5. Modificar descripción tarea");
            Console.WriteLine("6. Modificar estado tarea");
            Console.WriteLine("7. Eliminar tareas");
            Console.WriteLine("10. Salir");
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
                    Console.WriteLine("Tarea añadida correctamente.");
                    Console.WriteLine("Pulsa una tecla para continuar...");
                    Console.ReadKey(); // sin esto simplemete no se ve console.write debido aque lo imprime pero justo despues vuelve al while vuelve a imprimir el menu
                    break;
                case 2:
                    Console.WriteLine("Listado de tareas:");
                    var tasks = controller.ListTasks();
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("No hay tareas.");
                        break;
                    }
                    foreach (var taskItem in tasks)
                    {
                        var status = taskItem.Status ? "Completada" : "Pendiente";
                        Console.WriteLine($"Nombre: {taskItem.Name}");
                        Console.WriteLine($"Descripción: {taskItem.Description}");
                        Console.WriteLine($"Estado: " + status);
                        Console.WriteLine();
                    }
                    Console.WriteLine("Pulsa una tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Write("Nombre: ");
                    name = Console.ReadLine();
                    Console.WriteLine(controller.GetTask(name));
                    Console.WriteLine("Tarea modificada correctamente.");
                    Console.WriteLine("Pulsa una tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Write("Nombre: ");
                    name = Console.ReadLine();
                    Console.Write("Nuevo nombre: ");
                    string newName = Console.ReadLine();
                    controller.ModifyTaskName(name, newName);
                    Console.WriteLine("Tarea modificada correctamente.");
                    Console.WriteLine("Pulsa una tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.Write("Nombre: ");
                    name = Console.ReadLine();
                    Console.Write("Nueva descripcion: ");
                    string newDescription = Console.ReadLine();
                    controller.ModifyTaskDescription(name, newDescription);
                    Console.WriteLine("Tarea modificada correctamente.");
                    Console.WriteLine("Pulsa una tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.Write("Nombre: ");
                    name = Console.ReadLine();
                    Console.Write("Nuevo estado (Pendiente, Completada): ");
                    string newstatus = Console.ReadLine();
                    bool newStatusBool = newstatus == "Completada" ? true : false;
                    newStatusBool = newstatus == "Pendiente" ? false : false;
                    controller.ModifyTaskStatus(name, newStatusBool);
                    Console.WriteLine("Tarea modificada correctamente.");
                    Console.WriteLine("Pulsa una tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 7:
                    Console.Write("Nombre: ");
                    name = Console.ReadLine();
                    var task = controller.GetTask(name);
                    controller.DeleteTask(task);
                    Console.WriteLine("Tarea eliminada.");
                    Console.WriteLine("Pulsa una tecla para continuar...");
                    Console.ReadKey();
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
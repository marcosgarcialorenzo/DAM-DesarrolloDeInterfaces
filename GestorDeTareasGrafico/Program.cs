using GestorDeTareas.Controllers;
using GestorDeTareas.Repositories;
using GestorDeTareas.Views;

namespace GestorDeTareas;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // El fichero se guarda en %AppData%\GestorDeTareas\tareas.json
        var filePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "GestorDeTareas",
            "tareas.json");

        var repository = new TaskItemRepository(filePath);
        var controller = new TaskItemController(repository);

        Application.Run(new MainForm(controller));
    }
}

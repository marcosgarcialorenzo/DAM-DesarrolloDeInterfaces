namespace GestorDeTareas.Models;

public class TaskItem
{
    // Constructor sin parámetros: necesario para deserializar desde JSON.
    public TaskItem()
    {
    }

    public TaskItem(string name, string description, bool status = false)
    {
        Name = name;
        Description = description;
        Status = status;
    }

    // Identificador único: permite tener dos tareas con el mismo nombre
    // y localizar siempre la fila correcta en la interfaz.
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public bool Status { get; set; } // false = Pendiente, true = Completada
}

namespace GestorDeTareasGrafico.Models;

public class TaskItem
{
    public TaskItem(string name, string description)
    {
        this.Name = name;
        this.Description = description;
        this.Status = false; // false porque la tarea no se ha completado aun
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }
}
namespace GestorDeTareasGrafico.Models;

public class TaskItem
{
    public TaskItem(string name, string description, bool status = false)
    {
        Name = name;
        Description = description;
        Status = status;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }
}
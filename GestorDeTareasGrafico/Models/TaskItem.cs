namespace GestorDeTareasGrafico.Models;

public class TaskItem
{
    private string name;
    private string description;
    private bool status;

    public TaskItem(string name, string description)
    {
        this.Name = name;
        this.Description = description;
        this.Status = status;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }
}
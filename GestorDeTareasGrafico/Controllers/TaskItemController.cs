using GestorDeTareas.Models;
using GestorDeTareas.Repositories;

namespace GestorDeTareas.Controllers;

public class TaskItemController
{
    private readonly ITaskItemRepository<TaskItem> repository;

    public TaskItemController(ITaskItemRepository<TaskItem> repository)
    {
        this.repository = repository;
    }

    public void AddTask(string name, string description, bool status = false)
    {
        name = ValidateName(name);
        repository.Add(new TaskItem(name, description?.Trim() ?? "", status));
    }

    public List<TaskItem> ListTasks(TaskFilter filter = TaskFilter.All)
    {
        var all = repository.GetAll();
        return filter switch
        {
            TaskFilter.Pending => all.Where(t => !t.Status).ToList(),
            TaskFilter.Completed => all.Where(t => t.Status).ToList(),
            _ => all
        };
    }

    public TaskItem GetTask(Guid id)
    {
        return repository.GetById(id);
    }

    public void UpdateTask(Guid id, string name, string description, bool status)
    {
        name = ValidateName(name);
        repository.Update(id, name, description?.Trim() ?? "", status);
    }

    public void SetTaskStatus(Guid id, bool status)
    {
        var task = repository.GetById(id);
        if (task == null) return;
        repository.Update(id, task.Name, task.Description, status);
    }

    public void DeleteTask(Guid id)
    {
        repository.Delete(id);
    }

    private static string ValidateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("El nombre de la tarea no puede estar vacío.");
        return name.Trim();
    }
}

using ConsoleApp2.Models;

namespace ConsoleApp2.Repositories;

public class TaskItemRepository : ITaskItemRepository<TaskItem>
{
    private List<TaskItem> tasks = new List<TaskItem>();

    public void Add(TaskItem task)
    {
        tasks.Add(task);
    }

    public TaskItem GetTask(string name)
    {
        return tasks.FirstOrDefault(t => t.Name == name);
    }

    public void ModifyName(string name, string newName)
    {
        var task = GetTask(name);
        if (task != null)
        {
            task.Name = newName;
        }
    }

    public void ModifyDescription(string name, string newDescription)
    {
        var task = GetTask(name);
        if (task != null)
        {
            task.Description = newDescription;
        }
    }

    public void ModifyStatus(string name, bool newStatus)
    {
        var task = GetTask(name);
        if (task != null)
        {
            task.Status = newStatus;
        }
    }

    public void Delete(TaskItem task)
    {
        tasks.Remove(task);
    }
}
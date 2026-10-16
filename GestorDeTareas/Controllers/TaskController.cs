using ConsoleApp2.Models;
using ConsoleApp2.Repositories;

namespace ConsoleApp2.Controllers;

public class TaskController
{
    private readonly TaskItemRepository repository;

    public TaskController(TaskItemRepository repository)
    {
        this.repository = repository;
    }

    public void AddTask(string name, string description)
    {
        repository.Add(new TaskItem(name, description));
    }

    public List<TaskItem> ListTasks()
    {
        return repository.GetAll();
    }

    public TaskItem GetTask(string name)
    {
        return repository.GetTask(name);
    }

    public void ModifyTaskName(string name, string newName)
    {
        repository.ModifyName(name, newName);
    }

    public void ModifyTaskDescription(string name, string newDescription)
    {
        repository.ModifyDescription(name, newDescription);
    }

    public void ModifyTaskStatus(string name, bool newStatus)
    {
        repository.ModifyStatus(name, newStatus);
    }

    public void DeleteTask(TaskItem task)
    {
        repository.Delete(task);
    }
}
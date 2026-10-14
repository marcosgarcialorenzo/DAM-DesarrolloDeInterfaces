using ConsoleApp2.Models;

namespace ConsoleApp2.Repositories;

public interface ITaskItemRepository<T> where T : TaskItem
{
    public void Add(T task);
    public TaskItem GetTask(string name);
    public void ModifyName(string name, string newName);
    public void ModifyDescription(string name, string newDescription);
    public void ModifyStatus(string name, bool newStatus);
    public void Delete(T task);

}
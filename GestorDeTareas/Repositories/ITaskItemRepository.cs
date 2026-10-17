using GestorDeTareas.Models;

namespace GestorDeTareas.Repositories;

public interface ITaskItemRepository<T> where T : TaskItem
{
    public void Add(T task);
    public List<T> GetAll();
    public TaskItem GetTask(string name);
    public void ModifyName(string name, string newName);
    public void ModifyDescription(string name, string newDescription);
    public void ModifyStatus(string name, bool newStatus);
    public void Delete(T task);

}
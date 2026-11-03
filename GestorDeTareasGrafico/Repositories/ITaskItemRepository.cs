using GestorDeTareas.Models;

namespace GestorDeTareas.Repositories;

public interface ITaskItemRepository<T> where T : TaskItem
{
    void Add(T task);
    List<T> GetAll();
    T GetById(Guid id);
    void Update(Guid id, string name, string description, bool status);
    void Delete(Guid id);
}

using GestorDeTareasGrafico.Models;

namespace GestorDeTareasGrafico.Repositories;

public interface ITaskItemRepository<T> where T : TaskItem
{
    void Add(T task);
    List<T> GetAll();
    T GetTask(string name);
    void ModifyName(string name, string newName);
    void ModifyDescription(string name, string newDescription);
    void ModifyStatus(string name, bool newStatus);
    void Delete(T task);
}
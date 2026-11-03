using System.Text.Json;
using GestorDeTareas.Models;

namespace GestorDeTareas.Repositories;

public class TaskItemRepository : ITaskItemRepository<TaskItem>
{
    private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };

    private readonly string filePath;
    private readonly List<TaskItem> tasks;

    public TaskItemRepository(string filePath)
    {
        this.filePath = filePath;
        tasks = Load();
    }

    public void Add(TaskItem task)
    {
        tasks.Add(task);
        Save();
    }

    public List<TaskItem> GetAll()
    {
        return new List<TaskItem>(tasks);
    }

    public TaskItem GetById(Guid id)
    {
        return tasks.FirstOrDefault(t => t.Id == id);
    }

    public void Update(Guid id, string name, string description, bool status)
    {
        var task = GetById(id);
        if (task == null) return;

        task.Name = name;
        task.Description = description;
        task.Status = status;
        Save();
    }

    public void Delete(Guid id)
    {
        var task = GetById(id);
        if (task == null) return;

        tasks.Remove(task);
        Save();
    }

    // ---------- Persistencia en fichero JSON ----------

    private List<TaskItem> Load()
    {
        try
        {
            if (!File.Exists(filePath))
                return new List<TaskItem>();

            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<TaskItem>>(json) ?? new List<TaskItem>();
        }
        catch (Exception ex) when (ex is JsonException || ex is IOException)
        {
            // Fichero corrupto o no accesible: se arranca con la lista vacía.
            return new List<TaskItem>();
        }
    }

    private void Save()
    {
        Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);
        File.WriteAllText(filePath, JsonSerializer.Serialize(tasks, JsonOptions));
    }
}

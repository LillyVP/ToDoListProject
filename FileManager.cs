using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ToDoListProject
{
    public class FileManager
    {
        private string filePath;

        public FileManager(string filePath)
        {
            this.filePath = filePath;
        }

        public List<Task> LoadTasks()
        {
            if (!File.Exists(filePath))
            {
                return new List<Task>();
            }

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Task>>(json) ?? new List<Task>();
        }

        public void SaveTasks(IEnumerable<Task> tasks)
        {
            string json = JsonSerializer.Serialize(tasks);
            File.WriteAllText(filePath, json);
        }
    }
}

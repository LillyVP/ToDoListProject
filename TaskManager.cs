using System.Collections.Generic;
using System.Linq;

namespace ToDoListProject
{
    public class TaskManager
    {
        private List<Task> tasks;

        public TaskManager()
        {
            tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public IEnumerable<Task> GetAllTasks()
        {
            return tasks.ToList();
        }
    }
}

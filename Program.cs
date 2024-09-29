using System;

namespace ToDoListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();

            // Add some tasks to the task manager
            taskManager.AddTask(new Task(1, "Complete Assignment", "Finish the C# ToDoListProject", DateTime.Now.AddDays(2), Priority.High));
            taskManager.AddTask(new Task(2, "Go Grocery Shopping", "Buy food for the week", DateTime.Now.AddDays(1), Priority.Medium));

            // Display all tasks
            Console.WriteLine("All Tasks:");
            foreach (var task in taskManager.GetAllTasks())
            {
                Console.WriteLine(task);
            }

            // Update the first task
            Task updatedTask = new Task(1, "Complete Assignment", "Finish all remaining tasks in ToDoListProject", DateTime.Now.AddDays(3), Priority.High);
            taskManager.UpdateTask(updatedTask);

            // Display tasks after the update
            Console.WriteLine("\nUpdated Tasks:");
            foreach (var task in taskManager.GetAllTasks())
            {
                Console.WriteLine(task);
            }

            // Delete the second task
            taskManager.DeleteTask(2);

            // Display tasks after deletion
            Console.WriteLine("\nTasks after deletion:");
            foreach (var task in taskManager.GetAllTasks())
            {
                Console.WriteLine(task);
            }
        }
    }
}

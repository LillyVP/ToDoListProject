using System;
using System.Collections.Generic;

namespace ToDoListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();
            FileManager fileManager = new FileManager("launch.json");

            // Load tasks from file
            List<Task> loadedTasks = fileManager.LoadTasks();
            foreach (var task in loadedTasks)
            {
                taskManager.AddTask(task);
            }

            // Example usage
            Console.WriteLine("Welcome to the To-Do List Task Manager!");
            Console.WriteLine("Adding a new task...");

            Task newTask = new Task(1, "Complete Assignment", "Finish the C# project by the end of the week", DateTime.Now.AddDays(3), Priority.High);
            taskManager.AddTask(newTask);

            // Mark a task as completed
            Console.WriteLine("Marking task as completed...");
            newTask.MarkAsComplete();

            // Display all tasks
            Console.WriteLine("\nAll Tasks:");
            foreach (var task in taskManager.GetAllTasks())
            {
                Console.WriteLine(task);
            }

            // Save tasks to file
            fileManager.SaveTasks(taskManager.GetAllTasks());
        }
    }
}

using System;

namespace ToDoListProject
{
    public enum Priority
    {
        Low,
        Medium,
        High
    }

    public class Task
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime DueDate { get; private set; }
        public Priority TaskPriority { get; private set; }
        public bool IsCompleted { get; private set; }

        public Task(int id, string title, string description, DateTime dueDate, Priority priority)
        {
            Id = id;
            Title = title;
            Description = description;
            DueDate = dueDate;
            TaskPriority = priority;
            IsCompleted = false;
        }

        public void MarkAsComplete()
        {
            IsCompleted = true;
        }

        public override string ToString()
        {
            return $"[{(IsCompleted ? "X" : " ")}] {Title} - {Description} (Due: {DueDate.ToShortDateString()}, Priority: {TaskPriority})";
        }
    }
}

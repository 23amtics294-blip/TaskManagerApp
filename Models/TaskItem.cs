using System;
namespace TaskManagerApp.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool IsCompleted { get; set; }

        // ✅ Add this to fix "DueDate" errors in Views
        public DateTime? DueDate { get; set; }
    }
}

using EmployeeManagementSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Domain.Entities
{
    public class Goal
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; } = DateTime.UtcNow;
        public DateTime EndDate { get; set; } = DateTime.UtcNow.AddMonths(1); // Default to one month from start date
        public Status Status { get; set; } = Status.NotStarted; // Default status
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Foreign keys
        public Guid EmployeeId { get; set; } // The user to whom the goal belongs
        public Guid ManagerId { get; set; } // The manager who creates the goal

        // Navigation properties
        public User Employee { get; set; } = new User(); // Navigation property for employee
        public User Manager { get; set; } = new User(); // Navigation property for manager
    }
}

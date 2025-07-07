using EmployeeManagementSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public UserRole Role { get; set; } = UserRole.Employee; // Default role is Employee
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        //Foreign keys
        public Guid? ManagerId { get; set; }
        public Guid? DepartmentId { get; set; }

        // Navigation properties
        public User? Manager { get; set; } // Self-referencing relationship for manager
        public ICollection<User>? TeamMembers { get; set; } = new List<User>();// Team members under this manager
        public Department Department { get; set; } = new Department(); // Navigation property for department
        public ICollection<Goal>? Goals { get; set; } = new List<Goal>(); // Navigation property for goals
        public ICollection<Goal>? ManagedGoals { get; set; } = new List<Goal>(); // Goals created and managed by this user
        public ICollection<Evaluation>? Evaluations { get; set; } = new List<Evaluation>(); // Navigation property for evaluations
        public ICollection<Evaluation>? ManagedEvaluations { get; set; } = new List<Evaluation>(); // Evaluations managed by this user
    }
}

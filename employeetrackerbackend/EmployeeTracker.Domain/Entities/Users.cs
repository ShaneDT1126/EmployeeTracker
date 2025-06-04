using EmployeeTrackerBackend.EmployeeTracker.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace EmployeeTrackerBackend.EmployeeTracker.Domain.Entities
{
    public class Users
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        [StringLength(100, ErrorMessage = "First name cannot be longer than 100 characters")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(100, ErrorMessage = "Last name cannot be longer than 100 characters")]
        public string LastName { get; set; } = string.Empty;
        [EmailAddress(ErrorMessage = "Email is required")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password is required")]
        [StringLength(150, ErrorMessage = "Password must be at least 6 characters long", MinimumLength = 8)]
        public string Password { get; set; } = string.Empty;
        public UserRole Role { get; set; } = UserRole.Employee; // Default role is Employee
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        //Foreign keys
        public Guid? ManagerId { get; set; }
        public Guid? DepartmentId { get; set; }

        // Navigation properties
        public Users? Manager { get; set; } // Self-referencing relationship for manager
        public ICollection<Users>? TeamMembers { get; set; } = new List<Users>();// Team members under this manager
        public Departments Departments { get; set; } = new Departments(); // Navigation property for department
        public ICollection<Goals>? Goals { get; set; } = new List<Goals>(); // Navigation property for goals
        public ICollection <Goals>? ManagedGoals { get; set; } = new List<Goals>(); // Goals created and managed by this user
        public ICollection<Evaluations>? Evaluations { get; set; } = new List<Evaluations>(); // Navigation property for evaluations
    }
}

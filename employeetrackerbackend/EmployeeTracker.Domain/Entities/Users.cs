using EmployeeTrackerBackend.EmployeeTracker.Domain.Enums;

namespace EmployeeTrackerBackend.EmployeeTracker.Domain.Entities
{
    public class Users
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public UserRole role { get; set; } = UserRole.Employee; // Default role is Employee
        public string Role { get; set; } = string.Empty;
        public Guid? ManagerId { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

using System.ComponentModel.DataAnnotations;

namespace EmployeeTrackerBackend.EmployeeTracker.Domain.Entities
{
    public class Department
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Department name is required")]
        [StringLength(100, ErrorMessage = "Department name cannot be longer than 100 characters")]
        public string Name { get; set; } = string.Empty;

        // Navigation property for Users in this department
        public ICollection<User>? Users { get; set; } = new List<User>();
    }
}

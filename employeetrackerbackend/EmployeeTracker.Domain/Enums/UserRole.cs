using System.ComponentModel.DataAnnotations;

namespace EmployeeTrackerBackend.EmployeeTracker.Domain.Enums
{
    public enum UserRole
    {
        [Display(Name = "Employee")]
        Employee = 1,
        [Display(Name = "Manager")]
        Manager = 2,
        [Display(Name = "Admin")]
        Admin = 3
    }
}

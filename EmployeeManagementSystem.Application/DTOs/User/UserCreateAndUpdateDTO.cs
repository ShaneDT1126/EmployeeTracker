using EmployeeManagementSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Application.DTOs.User
{
    public class UserCreateAndUpdateDTO
    {
        [Required(ErrorMessage = "User ID is required")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = string.Empty;
        [Required(ErrorMessage = "Role is required")]
        public UserRole Role { get; set; } = UserRole.Employee; // Default role is Employee
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        //Foreign keys
        public Guid? ManagerId { get; set; }
        public Guid? DepartmentId { get; set; }
    }
}

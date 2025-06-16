using EmployeeManagementSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Application.DTOs.User
{
    public class UserDTO
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
    }
}

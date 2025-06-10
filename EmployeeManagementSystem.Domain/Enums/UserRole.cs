using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Domain.Enums
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

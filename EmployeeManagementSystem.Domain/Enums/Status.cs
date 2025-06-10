using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Domain.Enums
{
    public enum Status
    {
        [Display(Name = "Not Started")]
        NotStarted = 1,
        [Display(Name = "In Progress")]
        InProgress = 2,
        [Display(Name = "Completed")]
        Completed = 3,
    }
}

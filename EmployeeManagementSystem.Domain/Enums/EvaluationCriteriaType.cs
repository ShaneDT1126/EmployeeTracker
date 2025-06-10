using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Domain.Enums
{
    public enum EvaluationCriteriaType
    {
        [Display(Name = "Communication Skills")]
        Communication = 1,
        [Display(Name = "Teamwork")]
        Teamwork = 2,
        [Display(Name = "Problem Solving")]
        ProblemSolving = 3,
        [Display(Name = "Initiative")]
        Initiative = 4,
        [Display(Name = "Attendance")]
        Attendance = 5,
        [Display(Name = "Technical Skills")]
        TechnicalSkills = 6,
    }
}

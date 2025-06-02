using System.ComponentModel.DataAnnotations;

namespace EmployeeTrackerBackend.EmployeeTracker.Domain.Enums
{
    public enum EvaluationCriteriaType
    {
        [Display(Name = "Communication Skills")]
        Communication = 0,
        [Display(Name = "Teamwork")]
        Teamwork = 1,
        [Display(Name = "Problem Solving")]
        ProblemSolving = 2,
        [Display(Name = "Initiative")]
        Initiative = 3,
        [Display(Name = "Attendance")]
        Attendance = 4,
        [Display(Name = "Technical Skills")]
        TechnicalSkills = 5,
    }
}

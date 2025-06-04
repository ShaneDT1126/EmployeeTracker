using System.ComponentModel.DataAnnotations;

namespace EmployeeTrackerBackend.EmployeeTracker.Domain.Enums
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

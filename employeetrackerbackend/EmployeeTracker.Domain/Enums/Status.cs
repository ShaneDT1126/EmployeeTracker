using System.ComponentModel.DataAnnotations;

namespace EmployeeTrackerBackend.EmployeeTracker.Domain.Enums
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

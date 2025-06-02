using System.ComponentModel.DataAnnotations;

namespace EmployeeTrackerBackend.EmployeeTracker.Domain.Enums
{
    public enum Status
    {
        [Display(Name = "Not Started")]
        NotStarted = 0,
        [Display(Name = "In Progress")]
        InProgress = 1,
        [Display(Name = "Completed")]
        Completed = 2,
    }
}

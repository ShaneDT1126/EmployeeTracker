using EmployeeTrackerBackend.EmployeeTracker.Domain.Enums;

namespace EmployeeTrackerBackend.EmployeeTracker.Domain.Entities
{
    public class Goals
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid EmployeeId { get; set; }
        public DateTime StartDate { get; set; } = DateTime.UtcNow;
        public DateTime EndDate { get; set; } = DateTime.UtcNow.AddMonths(1); // Default to one month from start date
        public Status Status { get; set; } = Status.NotStarted; // Default status
    }
}

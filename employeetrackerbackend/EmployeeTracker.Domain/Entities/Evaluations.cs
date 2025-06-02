namespace EmployeeTrackerBackend.EmployeeTracker.Domain.Entities
{
    public class Evaluations
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid ManagerId { get; set; }
        public DateTime EvaluationDate { get; set; } = DateTime.UtcNow;
        public string SummaryComments { get; set; } = string.Empty;
    }
}

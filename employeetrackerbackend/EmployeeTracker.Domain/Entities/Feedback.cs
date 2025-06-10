using EmployeeTrackerBackend.EmployeeTracker.Domain.Enums;

namespace EmployeeTrackerBackend.EmployeeTracker.Domain.Entities
{
    public class Feedbacks
    {
        public Guid Id { get; set; }
        public string Message { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Foreign keys
        public Guid EvaluationId { get; set; }

        // Navigation properties
        public Evaluation Evaluation { get; set; } = new Evaluation(); // Navigation property for evaluation
    }
}

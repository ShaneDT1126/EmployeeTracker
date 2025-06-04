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
        public Evaluations Evaluation { get; set; } = new Evaluations(); // Navigation property for evaluation
    }
}

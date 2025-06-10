namespace EmployeeTrackerBackend.EmployeeTracker.Domain.Entities
{
    public class Evaluation
    {
        public Guid Id { get; set; }
        public DateTime EvaluationDate { get; set; } = DateTime.UtcNow;

        // Foreign keys
        public Guid EvaluatedUserId { get; set; }
        public Guid EvaluatorUserId { get; set; }


        // Navigation properties
        public User EvaluatedEmployee { get; set; } = new User(); // The employee being evaluated
        public User Manager { get; set; } = new User(); // The manager who evaluates the user
        public ICollection<EvaluationDetail>? EvaluationDetails { get; set; } = new List<EvaluationDetail>();
        public ICollection<Feedback>? Feedbacks { get; set; } = new List<Feedback>();
    }
}

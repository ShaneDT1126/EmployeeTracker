namespace EmployeeTrackerBackend.EmployeeTracker.Domain.Entities
{
    public class Evaluations
    {
        public Guid Id { get; set; }
        public DateTime EvaluationDate { get; set; } = DateTime.UtcNow;

        // Foreign keys
        public Guid EvaluatedUserId { get; set; }
        public Guid EvaluatorUserId { get; set; }


        // Navigation properties
        public ICollection<EvaluationDetail>? EvaluationDetails { get; set; } = new List<EvaluationDetail>();
        public ICollection<Feedbacks>? Feedbacks { get; set; } = new List<Feedbacks>();
    }
}

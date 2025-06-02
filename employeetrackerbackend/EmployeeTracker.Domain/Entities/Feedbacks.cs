using EmployeeTrackerBackend.EmployeeTracker.Domain.Enums;

namespace EmployeeTrackerBackend.EmployeeTracker.Domain.Entities
{
    public class Feedbacks
    {
        public Guid Id { get; set; }
        public Guid FromUserId { get; set; }
        public Guid ToUserId { get; set; }
        public string Message { get; set; } = string.Empty;
        public EvaluationCriteriaType Tag { get; set; } 
        public DateTime FeedbackDate { get; set; } = DateTime.UtcNow;
    }
}

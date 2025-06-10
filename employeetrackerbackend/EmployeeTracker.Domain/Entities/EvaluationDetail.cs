using EmployeeTrackerBackend.EmployeeTracker.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace EmployeeTrackerBackend.EmployeeTracker.Domain.Entities
{
    public class EvaluationDetail
    {
        public Guid Id { get; set; }
        public EvaluationCriteriaType EvaluationCriteriaType { get; set; } = EvaluationCriteriaType.Communication; // Default criteria type
        [Range(1, 5, ErrorMessage = "Score must be between 1 and 5.")]
        public int Score { get; set; }
        [StringLength(500, ErrorMessage = "Comment cannot be longer than 500 characters.")]
        public string? Comment { get; set; } = string.Empty;

        // Freign key
        public Guid EvaluationId { get; set; }

        // Navigation properties
        public Evaluation Evaluation { get; set; } = new Evaluation(); // Navigation property for evaluation
    }
}

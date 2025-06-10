using EmployeeTrackerBackend.EmployeeTracker.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace EmployeeTrackerBackend.EmployeeTracker.Domain.Entities
{
    public class EvaluationDetail
    {
        public Guid Id { get; set; }
        public EvaluationCriteriaType EvaluationCriteriaType { get; set; }
        [Range(1, 5, ErrorMessage = "Score must be between 1 and 5.")]
        public int Score { get; set; }
        public string? Comment { get; set; } = string.Empty;

        // Freign key
        public Guid EvaluationId { get; set; }

        // Navigation properties
        public Evaluations Evaluation { get; set; } = new Evaluations(); // Navigation property for evaluation
    }
}

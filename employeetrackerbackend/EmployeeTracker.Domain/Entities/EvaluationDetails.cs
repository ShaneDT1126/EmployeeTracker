using EmployeeTrackerBackend.EmployeeTracker.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace EmployeeTrackerBackend.EmployeeTracker.Domain.Entities
{
    public class EvaluationDetails
    {
        public Guid Id { get; set; }
        public Guid EvaluationId { get; set; }
        public EvaluationCriteriaType EvaluationCriteriaType { get; set; }
        [Range(1, 5, ErrorMessage = "Score must be between 1 and 5.")]
        public int Score { get; set; } 
        public string? Comments { get; set; }

    }
}

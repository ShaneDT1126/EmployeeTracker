using EmployeeManagementSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Domain.Entities
{
    public class EvaluationDetail
    {
        public Guid Id { get; set; }
        public EvaluationCriteriaType EvaluationCriteriaType { get; set; } = EvaluationCriteriaType.Communication; // Default criteria type
        public int Score { get; set; }
        public string? Comment { get; set; } = string.Empty;

        // Freign key
        public Guid EvaluationId { get; set; }

        // Navigation properties
        public Evaluation Evaluation { get; set; } = new Evaluation(); // Navigation property for evaluation
    }
}

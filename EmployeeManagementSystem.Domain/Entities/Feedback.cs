using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Domain.Entities
{
    public class Feedback
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(800, ErrorMessage = "Feedback message cannot be longer than 800 characters")]
        public string Message { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Foreign keys
        public Guid EvaluationId { get; set; }

        // Navigation properties
        public Evaluation Evaluation { get; set; } = new Evaluation(); // Navigation property for evaluation
    }
}

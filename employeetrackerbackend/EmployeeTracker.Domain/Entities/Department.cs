namespace EmployeeTrackerBackend.EmployeeTracker.Domain.Entities
{
    public class Department
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // Navigation property for Users in this department
        public ICollection<User>? Users { get; set; } = new List<User>();
    }
}

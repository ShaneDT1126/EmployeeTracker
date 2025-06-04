namespace EmployeeTrackerBackend.EmployeeTracker.Domain.Entities
{
    public class Departments
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // Navigation property for employees in this department
        public ICollection<Users>? Employees { get; set; } = new List<Users>();
    }
}

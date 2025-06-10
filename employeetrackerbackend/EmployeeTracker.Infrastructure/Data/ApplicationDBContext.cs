using Microsoft.EntityFrameworkCore;

namespace EmployeeTrackerBackend.EmployeeTracker.Infrastructure.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        // DbSets for the entities (creating tables in the database)
        public DbSet<Domain.Entities.Users> Users { get; set; }
        public DbSet<Domain.Entities.Departments> Departments { get; set; }
        public DbSet<Domain.Entities.Evaluations> Evaluations { get; set; }
        public DbSet<Domain.Entities.EvaluationDetails> EvaluationDetails { get; set; }
        public DbSet<Domain.Entities.Feedbacks> Feedbacks { get; set; }
        public DbSet<Domain.Entities.Goals> Goals { get; set; }


        // OnModelCreating method to configure the model and relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Add any additional model configurations here


        }
    }
}

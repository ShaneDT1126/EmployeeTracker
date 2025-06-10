using Microsoft.EntityFrameworkCore;

namespace EmployeeTrackerBackend.EmployeeTracker.Infrastructure.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        // DbSets for the entities (creating tables in the database)
        public DbSet<Domain.Entities.User> Users { get; set; }
        public DbSet<Domain.Entities.Department> Departments { get; set; }
        public DbSet<Domain.Entities.Evaluation> Evaluations { get; set; }
        public DbSet<Domain.Entities.EvaluationDetail> EvaluationDetails { get; set; }
        public DbSet<Domain.Entities.Feedback> Feedbacks { get; set; }
        public DbSet<Domain.Entities.Goal> Goals { get; set; }


        // OnModelCreating method to configure the model and relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Add any additional model configurations here

            // Relationship configurations
            modelBuilder.Entity<Domain.Entities.User>()
                .HasOne(u => u.Manager)
                .WithMany(u => u.TeamMembers)
                .HasForeignKey(u => u.ManagerId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            modelBuilder.Entity<Domain.Entities.User>()
                .HasOne(u => u.Departments)
                .WithMany(d => d.Users)
                .HasForeignKey(u => u.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            modelBuilder.Entity<Domain.Entities.Evaluation>()
                .HasOne(e => e.EvaluatedEmployee)
                .WithMany(u => u.Evaluations)
                .HasForeignKey(e => e.EvaluatedUserId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            modelBuilder.Entity<Domain.Entities.Evaluation>()
                .HasOne(e => e.Manager)
                .WithMany(u => u.ManagedEvaluations)
                .HasForeignKey(e => e.EvaluatorUserId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            modelBuilder.Entity<Domain.Entities.EvaluationDetail>()
                    .HasOne(ed => ed.Evaluation)
                    .WithMany(e => e.EvaluationDetails)
                    .HasForeignKey(ed => ed.EvaluationId)
                    .OnDelete(DeleteBehavior.Cascade); // Cascade delete for evaluation details

            modelBuilder.Entity<Domain.Entities.Feedback>()
                    .HasOne(f => f.Evaluation)
                    .WithMany(e => e.Feedbacks)
                    .HasForeignKey(f => f.EvaluationId)
                    .OnDelete(DeleteBehavior.Cascade); // Cascade delete for feedbacks

            modelBuilder.Entity<Domain.Entities.Goal>()
                .HasOne(g => g.Employee)
                .WithMany(u => u.Goals)
                .HasForeignKey(g => g.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete for goals

            modelBuilder.Entity<Domain.Entities.Goal>()
                .HasOne(g => g.Manager)
                .WithMany(u => u.ManagedGoals)
                .HasForeignKey(g => g.ManagerId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete for managed goals
        }
    }
}

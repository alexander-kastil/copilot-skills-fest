using Microsoft.EntityFrameworkCore;
using fitness_api.Models;

namespace fitness_api.Data;

public class FitnessDBContext : DbContext
{
    public FitnessDBContext(DbContextOptions<FitnessDBContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Exercise> Exercises { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Define relationships
        modelBuilder.Entity<Exercise>()
            .HasOne(e => e.Student)
            .WithMany(s => s.Exercises)
            .HasForeignKey(e => e.StudentId)
            .OnDelete(DeleteBehavior.Cascade);

        // Seed data for Students
        modelBuilder.Entity<Student>().HasData(
            new Student
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(2000, 1, 15)
            },
            new Student
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith",
                DateOfBirth = new DateTime(2001, 5, 20)
            },
            new Student
            {
                Id = 3,
                FirstName = "Michael",
                LastName = "Johnson",
                DateOfBirth = new DateTime(1999, 8, 10)
            }
        );

        // Seed data for Exercises
        modelBuilder.Entity<Exercise>().HasData(
            // Exercises for Student 1
            new Exercise
            {
                Id = 1,
                StudentId = 1,
                Date = DateTime.Now.AddDays(-5),
                Duration = 45,
                Comments = "Cardio workout"
            },
            new Exercise
            {
                Id = 2,
                StudentId = 1,
                Date = DateTime.Now.AddDays(-3),
                Duration = 60,
                Comments = "Strength training"
            },
            new Exercise
            {
                Id = 3,
                StudentId = 1,
                Date = DateTime.Now.AddDays(-1),
                Duration = 30,
                Comments = "Yoga session"
            },

            // Exercises for Student 2
            new Exercise
            {
                Id = 4,
                StudentId = 2,
                Date = DateTime.Now.AddDays(-6),
                Duration = 50,
                Comments = "Swimming"
            },
            new Exercise
            {
                Id = 5,
                StudentId = 2,
                Date = DateTime.Now.AddDays(-4),
                Duration = 40,
                Comments = "Running"
            },
            new Exercise
            {
                Id = 6,
                StudentId = 2,
                Date = DateTime.Now.AddDays(-2),
                Duration = 55,
                Comments = "Cycling"
            },

            // Exercises for Student 3
            new Exercise
            {
                Id = 7,
                StudentId = 3,
                Date = DateTime.Now.AddDays(-7),
                Duration = 65,
                Comments = "Basketball practice"
            },
            new Exercise
            {
                Id = 8,
                StudentId = 3,
                Date = DateTime.Now.AddDays(-5),
                Duration = 70,
                Comments = "Boxing training"
            },
            new Exercise
            {
                Id = 9,
                StudentId = 3,
                Date = DateTime.Now.AddDays(-3),
                Duration = 45,
                Comments = "Pilates class"
            }
        );
    }
}
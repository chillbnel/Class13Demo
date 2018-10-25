using Class13Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class13Demo.Data
{
    public class EnrollmentDbContext : DbContext
    {
        public EnrollmentDbContext(DbContextOptions<EnrollmentDbContext> options) : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseEnrollments>().HasKey(
                ce => new { ce.CourseID, ce.StudentID }
                );

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    ID = 1,
                    FirstName = "Brian",
                    LastName = "Nelson",
                    Age = 36
                },

                new Student
                {
                    ID = 2,
                    FirstName = "Eric",
                    LastName = "Nelson",
                    Age = 33
                }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    ID = 1,
                    Name = "ethics",
                    Technology = Technology.dotnet,
                    Price = 300
                },

                new Course
                {
                    ID = 2,
                    Name = "Advanced Ninja",
                    Technology = Technology.dotnet,
                    Price = 300
                }
            );
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Transcript> Transcripts { get; set; }
        public DbSet<CourseEnrollments> CourseEnrollments { get; set; }
    }
}

using ContosoU_2019.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU_2019.Data
{
    //jconnors: Part 3: Create the database context
    public class SchoolContext:DbContext
    {
        //Constructor
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
            //jconnors
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }


        /*
         * Plural table names by default:
         * When the database is created (from migration process), EF creates tables that have
         * the same names as the DbSet property names.
         * -> Just a developer debate (plural vs singular table names)
         */

        //Override the behaviour using Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            //modelBuilder.Entity<Student>().ToTable("Student");
            //modelBuilder.Entity<Instructor>().ToTable("Instructor");
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<CourseAssignment>().ToTable("CourseAssignment");

            //Composite PK on CourseAssignment (CourseID, InstructorID)
            modelBuilder.Entity<CourseAssignment>().HasKey(c => new { c.CourseID, c.InstructorID });
        }
    }
}

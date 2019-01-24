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

    }
}

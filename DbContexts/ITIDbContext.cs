using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Program.Modules;

namespace Program.DbContexts
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = ITIdb02; Trusted_Connection = true; TrustServerCertificate = true; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        DbSet<Course> Courses { get; set; }
        DbSet<CourseInstructor> CourseInstructor { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Instructor> Instructors { get; set; }
        DbSet<StudCourse> StudCourse { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<Topic> Topics { get; set; }
    }
}

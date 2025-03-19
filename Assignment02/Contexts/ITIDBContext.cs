using Assignment02.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02.Contexts
{
    internal class ITIDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITIDB;Trusted_Connection=True;Encrypt=False", options => options.UseDateOnlyTimeOnly());

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoursIns>()
                .HasKey(c => new { c.Ins_Id, c.Course_ID });
            modelBuilder.Entity<StudentCourse>()
                .HasKey(c => new { c.St_ID, c.Couse_ID });
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instrucotr> Instrucotrs { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> studentCourses { get; set; }
        public DbSet<CoursIns> CoursIns { get; set; }

    }
}

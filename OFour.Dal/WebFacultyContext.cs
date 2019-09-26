using Microsoft.EntityFrameworkCore;
using OFour.Core.Entities;
using OFour.Dal.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Text;

namespace OFour.Dal
{
    public class WebFacultyContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Cources { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }


        public WebFacultyContext(DbContextOptions options) : base(options)
        {
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new StudentCourseConfiguration());

        }
    }
}

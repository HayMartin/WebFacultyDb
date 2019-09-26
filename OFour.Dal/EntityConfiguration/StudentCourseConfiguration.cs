using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OFour.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OFour.Dal.EntityConfiguration
{
    class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(x => new { x.CourseID, x.StudentID });


            builder.HasOne(x => x.Cource)
                   .WithMany(x => x.StudentCourses)
                   .HasForeignKey(x => x.CourseID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Student)
                   .WithMany(x => x.StudentCourses)
                   .HasForeignKey(x => x.StudentID)
                   .OnDelete(DeleteBehavior.Restrict);

        }

       
    }
}

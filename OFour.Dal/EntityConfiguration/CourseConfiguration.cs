using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OFour.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OFour.Dal.EntityConfiguration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();


            builder.HasOne(x => x.Subject)
                   .WithMany(x => x.Cources)
                   .HasForeignKey(x => x.SubjectID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Teacher)
                   .WithMany(x => x.Cources)
                   .HasForeignKey(x => x.TeacherID)
                   .OnDelete(DeleteBehavior.Restrict);


        }


    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OFour.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OFour.Dal.EntityConfiguration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(student => student.Id);
            builder.Property(student => student.Id).ValueGeneratedOnAdd();
            builder.Property(student => student.FirstName).HasColumnType("varchar(20)").IsRequired();
            builder.Property(student => student.LastName).HasColumnType("varchar(30)").IsRequired();
            builder.Property(student => student.Email).HasColumnType("varchar(60)").IsRequired();//unique
            builder.Property(student => student.Phone).HasColumnType("varchar(12)").IsRequired();//unique
            builder.Property(student => student.BirthDate).HasColumnType("Date");
            builder.Property(student => student.StartDay).HasColumnType("Date").HasDefaultValue(DateTime.Now);

            builder.HasAlternateKey(student => student.Email);
            builder.HasAlternateKey(student => student.Phone);






        }

       
    }
}

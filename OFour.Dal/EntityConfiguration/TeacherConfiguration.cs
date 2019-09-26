
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OFour.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OFour.Dal.EntityConfiguration
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.FirstName).HasColumnType("varchar(20)").IsRequired();
            builder.Property(x => x.LastName).HasColumnType("varchar(30)").IsRequired();
            builder.Property(x => x.Phone).HasColumnType("varchar(12)").IsRequired();

            builder.HasAlternateKey(x => x.Phone);




        }

       
    }
}

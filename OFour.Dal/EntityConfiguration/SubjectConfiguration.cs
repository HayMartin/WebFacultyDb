using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OFour.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OFour.Dal.EntityConfiguration
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.SubjectName).HasColumnType("nvarchar(40)").IsRequired();



        }

      
    }
}

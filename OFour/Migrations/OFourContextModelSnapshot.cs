﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OFour.Dal;

namespace OFour.Migrations
{
    [DbContext(typeof(WebFacultyContext))]
    partial class OFourContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OFour.Core.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SubjectID");

                    b.Property<int>("TeacherID");

                    b.HasKey("Id");

                    b.HasIndex("SubjectID");

                    b.HasIndex("TeacherID");

                    b.ToTable("Cources");
                });

            modelBuilder.Entity("OFour.Core.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("Date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("varchar(12)");

                    b.Property<DateTime>("StartDay")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValue(new DateTime(2019, 9, 20, 14, 30, 0, 19, DateTimeKind.Local).AddTicks(281));

                    b.HasKey("Id");

                    b.HasAlternateKey("Email");

                    b.HasAlternateKey("Phone");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("OFour.Core.Entities.StudentCourse", b =>
                {
                    b.Property<int>("CourseID");

                    b.Property<int>("StudentID");

                    b.Property<bool>("Status");

                    b.HasKey("CourseID", "StudentID");

                    b.HasIndex("StudentID");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("OFour.Core.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("OFour.Core.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("varchar(12)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Phone");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("OFour.Core.Entities.Course", b =>
                {
                    b.HasOne("OFour.Core.Entities.Subject", "Subject")
                        .WithMany("Cources")
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OFour.Core.Entities.Teacher", "Teacher")
                        .WithMany("Cources")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OFour.Core.Entities.StudentCourse", b =>
                {
                    b.HasOne("OFour.Core.Entities.Course", "Cource")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OFour.Core.Entities.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}

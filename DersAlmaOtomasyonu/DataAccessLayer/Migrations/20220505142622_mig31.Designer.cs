﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220505142622_mig31")]
    partial class mig31
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.CourseSelection", b =>
                {
                    b.Property<int>("CourseSelectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("CourseSelectionId");

                    b.HasIndex("LessonId");

                    b.HasIndex("StudentId");

                    b.ToTable("CourseSelections");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Departman", b =>
                {
                    b.Property<int>("DepartmanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmanName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartmanPresident")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmanId");

                    b.ToTable("Departmans");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Lesson", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LessonCredit")
                        .HasColumnType("int");

                    b.Property<string>("LessonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LessonTeacher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PeriodId")
                        .HasColumnType("int");

                    b.HasKey("LessonId");

                    b.HasIndex("PeriodId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Period", b =>
                {
                    b.Property<int>("PeriodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PeriodNumber")
                        .HasColumnType("int");

                    b.HasKey("PeriodId");

                    b.ToTable("Periods");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmanId")
                        .HasColumnType("int");

                    b.Property<int>("PeriodId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StudentBirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("StudentFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StudentRegisterDate")
                        .HasColumnType("datetime2");

                    b.HasKey("StudentId");

                    b.HasIndex("DepartmanId");

                    b.HasIndex("PeriodId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EntityLayer.Concrete.CourseSelection", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Lesson", "Lesson")
                        .WithMany("CourseSelections")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Student", "Student")
                        .WithMany("CourseSelections")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Lesson", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Period", "Period")
                        .WithMany("Lessons")
                        .HasForeignKey("PeriodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Period");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Student", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Departman", "Departman")
                        .WithMany("Students")
                        .HasForeignKey("DepartmanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Period", "Period")
                        .WithMany("Students")
                        .HasForeignKey("PeriodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departman");

                    b.Navigation("Period");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Departman", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Lesson", b =>
                {
                    b.Navigation("CourseSelections");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Period", b =>
                {
                    b.Navigation("Lessons");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Student", b =>
                {
                    b.Navigation("CourseSelections");
                });
#pragma warning restore 612, 618
        }
    }
}

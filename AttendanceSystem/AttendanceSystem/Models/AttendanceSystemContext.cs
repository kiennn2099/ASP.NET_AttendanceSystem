using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AttendanceSystem.Models
{
    public partial class AttendanceSystemContext : DbContext
    {
        public AttendanceSystemContext()
        {
        }

        public AttendanceSystemContext(DbContextOptions<AttendanceSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attendance> Attendances { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<ClassMember> ClassMembers { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Schedule> Schedules { get; set; } = null!;
        public virtual DbSet<Staff> Staff { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(config.GetConnectionString("DBContext"));

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.ToTable("Attendance");

                entity.Property(e => e.AttendanceId)
                    .ValueGeneratedNever()
                    .HasColumnName("AttendanceID");

                entity.Property(e => e.AttendanceStatus).HasMaxLength(20);

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK_ScheduleAttendance");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_StudentAttendance");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.Property(e => e.ClassId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClassID");

                entity.Property(e => e.ClassName).HasMaxLength(100);
            });

            modelBuilder.Entity<ClassMember>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ClassMember");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Class)
                    .WithMany()
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__ClassMemb__Class__2D27B809");

                entity.HasOne(d => d.Student)
                    .WithMany()
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__ClassMemb__Stude__2B3F6F97");

                entity.HasOne(d => d.Subject)
                    .WithMany()
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__ClassMemb__Subje__2C3393D0");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("Schedule");

                entity.Property(e => e.ScheduleId)
                    .ValueGeneratedNever()
                    .HasColumnName("ScheduleID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__Schedule__ClassI__31EC6D26");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__Schedule__Subjec__30F848ED");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__Schedule__Teache__300424B4");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.Property(e => e.StaffId)
                    .ValueGeneratedNever()
                    .HasColumnName("StaffID");

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.Position).HasMaxLength(100);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_StaffRole");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.StudentId)
                    .ValueGeneratedNever()
                    .HasColumnName("StudentID");

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_StudentRole");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.Property(e => e.SubjectId)
                    .ValueGeneratedNever()
                    .HasColumnName("SubjectID");

                entity.Property(e => e.SubjectName).HasMaxLength(100);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.TeacherId)
                    .ValueGeneratedNever()
                    .HasColumnName("TeacherID");

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_TeacherRole");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ElectronicDiary.Database;

public partial class DatabaseForElectronicDiaryContext : DbContext
{
    public DatabaseForElectronicDiaryContext()
    {
    }

    public DatabaseForElectronicDiaryContext(DbContextOptions<DatabaseForElectronicDiaryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<GroupSchedule> GroupsSchedule { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<LessonTimeTable> LessonsTimes { get; set; }

    public virtual DbSet<Semester> Semesters { get; set; }

    public virtual DbSet<StudentNote> StudentsNotes { get; set; }

    public virtual DbSet<StudentMark> StudentsMarks { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<TypeOfMark> TypeOfMarks { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<WeekType> WeekTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=../../../Database/DatabaseForElectronicDiary.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().Property("UserId").HasField("userId");
        modelBuilder.Entity<User>().Property("UserLogin").HasField("userLogin");
        modelBuilder.Entity<User>().Property("UserPassword").HasField("userPassword");
        modelBuilder.Entity<User>().Property("IsAccountActive").HasField("isAccountActive");
        modelBuilder.Entity<User>().Property("IsAdmin").HasField("isAdmin");

        modelBuilder.Entity<GroupSchedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId);

            entity.ToTable("GroupsScheduleTable");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupsScheduleTables)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Subject).WithMany(p => p.GroupsScheduleTables)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.WeekType).WithMany(p => p.GroupsScheduleTables)
                .HasForeignKey(d => d.WeekTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("GroupsTable");

            entity.HasIndex(e => e.GroupName, "IX_GroupsTable_GroupName").IsUnique();
        });

        modelBuilder.Entity<LessonTimeTable>(entity =>
        {
            entity.HasKey(e => e.LessonId);

            entity.ToTable("LessonsTimeTable");

            entity.HasIndex(e => e.LessonTime, "IX_LessonsTimeTable_LessonTime").IsUnique();
        });

        modelBuilder.Entity<Semester>(entity =>
        {
            entity.HasKey(e => e.SemesterId);

            entity.ToTable("SemestersTable");

            entity.HasIndex(e => e.SemesterName, "IX_SemestersTable_SemesterName").IsUnique();
        });

        modelBuilder.Entity<StudentNote>(entity =>
        {
            entity.HasKey(e => e.NoteId);

            entity.ToTable("StudentNotesTable");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentNotesTables)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Subject).WithMany(p => p.StudentNotesTables)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<StudentMark>(entity =>
        {
            entity.HasKey(e => e.MarkId);

            entity.ToTable("StudentsMarksTable");

            entity.HasOne(d => d.Semester).WithMany(p => p.StudentsMarksTables)
                .HasForeignKey(d => d.SemesterId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Student).WithMany(p => p.StudentsMarksTables)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Subject).WithMany(p => p.StudentsMarksTables)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TypeOfMark).WithMany(p => p.StudentsMarksTables)
                .HasForeignKey(d => d.TypeOfMarkId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId);

            entity.ToTable("StudentsTable");

            entity.HasIndex(e => e.NumberInUserTable, "IX_StudentsTable_NumberInUserTable").IsUnique();

            entity.HasOne(d => d.NumberInUserTableNavigation).WithOne(p => p.StudentsTable)
                .HasForeignKey<Student>(d => d.NumberInUserTable)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.StudentGroupNumberNavigation).WithMany(p => p.StudentsTables)
                .HasForeignKey(d => d.StudentGroupNumber)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.SubjectId);

            entity.ToTable("SubjectsTable");

            entity.HasIndex(e => e.SubjectName, "IX_SubjectsTable_SubjectName").IsUnique();
        });

        modelBuilder.Entity<TypeOfMark>(entity =>
        {
            entity.HasKey(e => e.TypeOfMarkId);

            entity.ToTable("TypeOfMarksTable");

            entity.HasIndex(e => e.TypeOfMarkName, "IX_TypeOfMarksTable_TypeOfMarkName").IsUnique();
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("UsersTable");

            entity.HasIndex(e => e.UserLogin, "IX_UsersTable_UserLogin").IsUnique();
        });

        modelBuilder.Entity<WeekType>(entity =>
        {
            entity.HasKey(e => e.WeekTypeId);

            entity.ToTable("WeekTypeTable");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

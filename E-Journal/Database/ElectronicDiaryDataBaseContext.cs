using Microsoft.EntityFrameworkCore;

namespace ElectronicDiary.Database;

public partial class ElectronicDiaryDataBaseContext : DbContext
{
    public virtual DbSet<GroupSchedule> GroupsSchedule { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<LessonTimetable> LessonsTimes { get; set; }

    public virtual DbSet<Semester> Semesters { get; set; }

    public virtual DbSet<StudentNote> StudentsNotes { get; set; }

    public virtual DbSet<StudentMark> StudentsMarks { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<MarkType> MarksTypes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<WeekType> WeekTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlite("Data Source=../../../Database/DatabaseForElectronicDiary.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GroupSchedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId);

            entity.ToTable("GroupsSchedulesTable");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupsScheduleTable)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Subject).WithMany(p => p.GroupsScheduleTable)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.WeekType).WithMany(p => p.GroupsScheduleTable)
                .HasForeignKey(d => d.WeekTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("GroupsTable");

            entity.HasIndex(e => e.GroupName, "IX_GroupsTable_GroupName").IsUnique();
        });

        modelBuilder.Entity<LessonTimetable>(entity =>
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

            entity.ToTable("StudentsNotesTable");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentNotesTable)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Subject).WithMany(p => p.StudentNotesTable)
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

            entity.HasOne(d => d.Student).WithMany(p => p.StudentsMarksTable)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Subject).WithMany(p => p.StudentsMarksTable)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TypeOfMark).WithMany(p => p.StudentsMarksTable)
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

            entity.HasOne(d => d.StudentGroupNumberNavigation).WithMany(p => p.StudentsTable)
                .HasForeignKey(d => d.StudentGroupNumber)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.SubjectId);

            entity.ToTable("SubjectsTable");

            entity.HasIndex(e => e.SubjectName, "IX_SubjectsTable_SubjectName").IsUnique();
        });

        modelBuilder.Entity<MarkType>(entity =>
        {
            entity.HasKey(e => e.TypeOfMarkId);

            entity.ToTable("MarksTypesTable");

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

            entity.ToTable("WeeksTypesTable");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
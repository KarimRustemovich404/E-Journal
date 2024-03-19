using Microsoft.EntityFrameworkCore;

namespace WorkWithDatabase;

public partial class DatabaseForElectronicDiaryContext : DbContext
{
    public DatabaseForElectronicDiaryContext()
    {
    }

    public DatabaseForElectronicDiaryContext(DbContextOptions<DatabaseForElectronicDiaryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administrator> Administrators { get; set; }

    public virtual DbSet<ElectronicDiaryUser> ElectronicDiaryUsers { get; set; }

    public virtual DbSet<StudentExamScores> ExamScores { get; set; }

    public virtual DbSet<StudyGroup> Groups { get; set; }

    public virtual DbSet<LessonsTimeTable> LessonsTime { get; set; }

    public virtual DbSet<StudentPointsForSemesterWork> PointsForSemesterWork { get; set; }

    public virtual DbSet<StudentNotesForClasses> StudentNotesForClasses { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<GroupSchedule> StudyGroupSchedule { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=../../../Database/DatabaseForElectronicDiary.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ElectronicDiaryUser>().Property("UserId").HasField("userId");
        modelBuilder.Entity<ElectronicDiaryUser>().Property("UserLogin").HasField("userLogin");
        modelBuilder.Entity<ElectronicDiaryUser>().Property("UserPassword").HasField("userPassword");
        modelBuilder.Entity<ElectronicDiaryUser>().Property("IsAccountActive").HasField("isAccountActive");
        modelBuilder.Entity<ElectronicDiaryUser>().Property("IsAdmin").HasField("isAdmin");


        modelBuilder.Entity<Administrator>().Property("AdministratorId").HasField("administratorId");
        modelBuilder.Entity<Administrator>().Property("NumberInUserTable").HasField("numberInUserTable");
        modelBuilder.Entity<Administrator>().Property("AdministratorName").HasField("administratorName");
        modelBuilder.Entity<Administrator>().Property("AdministratorSurname").HasField("administratorSurname");
        modelBuilder.Entity<Administrator>().Property("AdministratorPatronymic").HasField("administratorPatronymic");

        modelBuilder.Entity<Administrator>(entity =>
        {
            entity.HasKey(e => e.AdministratorId);

            entity.ToTable("AdministratorsTable");

            entity.HasIndex(e => e.NumberInUserTable, "IX_AdministratorsTable_NumberInUserTable").IsUnique();

            entity.HasOne(d => d.NumberInUserTableNavigation).WithOne(p => p.AdministratorsTable)
                .HasForeignKey<Administrator>(d => d.NumberInUserTable)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ElectronicDiaryUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("ElectronicDiaryUsersTable");

            entity.HasIndex(e => e.UserLogin, "IX_ElectronicDiaryUsersTable_UserLogin").IsUnique();
        });

        modelBuilder.Entity<StudentExamScores>(entity =>
        {
            entity.HasKey(e => e.StudentId);

            entity.ToTable("ExamScoresTable");

            entity.Property(e => e.StudentId).ValueGeneratedNever();

            entity.HasOne(d => d.Student).WithOne(p => p.ExamScoresTable)
                .HasForeignKey<StudentExamScores>(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<StudyGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("GroupsTable");

            entity.HasIndex(e => e.GroupName, "IX_GroupsTable_GroupName").IsUnique();
        });

        modelBuilder.Entity<LessonsTimeTable>(entity =>
        {
            entity.HasKey(e => e.LessonId);

            entity.ToTable("LessonsTimeTable");
        });

        modelBuilder.Entity<StudentPointsForSemesterWork>(entity =>
        {
            entity.HasKey(e => e.StudentId);

            entity.ToTable("PointsForSemesterWorkTable");

            entity.Property(e => e.StudentId).ValueGeneratedNever();

            entity.HasOne(d => d.Student).WithOne(p => p.PointsForSemesterWorkTable)
                .HasForeignKey<StudentPointsForSemesterWork>(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<StudentNotesForClasses>(entity =>
        {
            entity.HasKey(e => e.StudentId);

            entity.ToTable("StudentNotesForClassesTable");

            entity.Property(e => e.StudentId).ValueGeneratedNever();

            entity.HasOne(d => d.Student).WithOne(p => p.StudentNotesForClassesTable)
                .HasForeignKey<StudentNotesForClasses>(d => d.StudentId)
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

        modelBuilder.Entity<GroupSchedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId);

            entity.ToTable("StudyGroupScheduleTable");

            entity.HasIndex(e => e.GroupNumberInGroupTable, "IX_StudyGroupScheduleTable_GroupNumberInGroupTable").IsUnique();

            entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

            entity.HasOne(d => d.GroupNumberInGroupTableNavigation).WithOne(p => p.StudyGroupScheduleTable)
                .HasForeignKey<GroupSchedule>(d => d.GroupNumberInGroupTable)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

namespace WorkWithDatabase;

public partial class StudentPointsForSemesterWork
{
    public int StudentId { get; set; }

    public int MathematicalAnalysis { get; set; }

    public int AlgebraAndGeometry { get; set; }

    public int ProgrammingTechnologies { get; set; }

    public int PhysicalCulture { get; set; }

    public int History { get; set; }

    public int English { get; set; }

    public virtual Student Student { get; set; } = null!;
}

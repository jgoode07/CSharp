public abstract class Shape
{
    public string? Colour { get; set; }

    // Each shape will calculate this differently
    public abstract double Area { get; }
}
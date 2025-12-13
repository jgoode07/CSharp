public class Circle : Shape
{
    public double Radius { get; set; }

    // Area = pie r squared
    public override double Area => Math.PI * Radius * Radius;
}
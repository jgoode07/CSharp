public class Rectangle : Shape
{
    public double Height { get; set; }
    public double Width { get; set; }

    // Area = height × width
    public override double Area => Height * Width;
}
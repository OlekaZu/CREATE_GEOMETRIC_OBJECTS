using System;

namespace GeometricObjetsLibrary.GeometricModels;

public class Line : GeometricModel
{
    public string? Name { get; set; }
    public double CoordinateX1 { get; set; }
    public double CoordinateY1 { get; set; }
    public double CoordinateX2 { get; set; }
    public double CoordinateY2 { get; set; }

    public Line() { }

    public override void Draw()
    {
        Console.WriteLine($"{Name} at ({CoordinateX1}, {CoordinateY1}), ({CoordinateX2}, {CoordinateY2})");
    }

    public override double Perimeter()
    {
        double perimeter = 0;
        Console.WriteLine($"{Name}: perimeter = {perimeter}");
        return perimeter;
    }

    public override double Square()
    {
        double square = 0;
        Console.WriteLine($"{Name}: square = {square}");
        return square;
    }
}

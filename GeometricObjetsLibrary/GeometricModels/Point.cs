using System;

namespace GeometricObjetsLibrary.GeometricModels;

public class Point : GeometricModel
{
    public string? Name { get; set; }
    public double CoordinateX { get; set; }
    public double CoordinateY { get; set; }

    public Point() { }

    public override void Draw()
    {
        Console.WriteLine($"{Name} at ({CoordinateX}, {CoordinateY})");
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

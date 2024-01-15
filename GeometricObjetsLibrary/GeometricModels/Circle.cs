using System;
using System.Reflection.Metadata;

namespace GeometricObjetsLibrary.GeometricModels;

public class Circle : GeometricModel
{
    public string? Name { get; set; }
    public double CoordinateX { get; set; }
    public double CoordinateY { get; set; }
    public double Radius { get; set; }

    public Circle() { }

    public override void Draw()
    {
        Console.WriteLine($"{Name} at ({CoordinateX}, {CoordinateY}), radius = {Radius}");
    }

    public override double Perimeter()
    {
        double perimeter = 2 * Math.PI * Radius;
        Console.WriteLine($"{Name}: perimeter = {perimeter}");
        return perimeter;
    }

    public override double Square()
    {
        double square = Math.PI * Math.Pow(Radius, 2);
        Console.WriteLine($"{Name}: square = {square}");
        return square;
    }
}

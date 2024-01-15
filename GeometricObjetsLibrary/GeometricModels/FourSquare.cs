using System;

namespace GeometricObjetsLibrary.GeometricModels;

public class FourSquare : GeometricModel
{
    public string? Name { get; set; }
    public double CoordinateX { get; set; }
    public double CoordinateY { get; set; }
    public double Length { get; set; }

    public FourSquare() { }

    public override void Draw()
    {
        Console.WriteLine($"{Name} at ({CoordinateX}, {CoordinateY}), side length = {Length}");
    }

    public override double Perimeter()
    {
        double perimeter = 4 * Length;
        Console.WriteLine($"{Name}: perimeter = {perimeter}");
        return perimeter;
    }

    public override double Square()
    {
        double square = Math.Pow(Length, 2);
        Console.WriteLine($"{Name}: square = {square}");
        return square;
    }
}

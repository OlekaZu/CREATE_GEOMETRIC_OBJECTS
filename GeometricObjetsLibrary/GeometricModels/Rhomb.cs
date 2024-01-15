using System;
using System.Reflection.Metadata;

namespace GeometricObjetsLibrary.GeometricModels;

public class Rhomb : GeometricModel
{
    public string? Name { get; set; }
    public double CoordinateX { get; set; }
    public double CoordinateY { get; set; }
    public double Heigth { get; set; }
    public double Width { get; set; }

    public Rhomb() { }

    public override void Draw()
    {
        Console.WriteLine($"{Name} at ({CoordinateX}, {CoordinateY}), height = {Heigth}, width = {Width}");
    }

    public override double Perimeter()
    {
        double perimeter = 4 * Math.Sqrt(Math.Pow(Heigth / 2, 2) + Math.Pow(Width / 2, 2));
        Console.WriteLine($"{Name}: perimeter = {perimeter}");
        return perimeter;
    }

    public override double Square()
    {
        double square = Heigth * Width / 2;
        Console.WriteLine($"{Name}: square = {square}");
        return square;
    }
}

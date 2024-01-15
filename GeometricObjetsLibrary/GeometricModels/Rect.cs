using GeometricObjetsLibrary;
using System;
using System.Reflection.Metadata;

namespace GeometricObjetsLibrary.GeometricModels;

public class Rect : GeometricModel, IEquatable<Rect>
{
    public string? Name { get; set; }
    public double CoordinateX1 { get; set; }
    public double CoordinateY1 { get; set; }
    public double CoordinateX2 { get; set; }
    public double CoordinateY2 { get; set; }

    public Rect() { }

    public override void Draw()
    {
        Console.WriteLine($"{Name} at ({CoordinateX1}, {CoordinateY1}), ({CoordinateX2}, {CoordinateY2})");
    }

    public override double Perimeter()
    {
        double perimeter = Math.Abs(CoordinateX2 - CoordinateX1) * 2 + Math.Abs(CoordinateY2 - CoordinateY1) * 2;
        Console.WriteLine($"{Name}: perimeter = {perimeter:F2}");
        return perimeter;
    }

    public override double Square()
    {
        double square = Math.Abs(CoordinateX2 - CoordinateX1) * Math.Abs(CoordinateY2 - CoordinateY1);
        Console.WriteLine($"{Name}: square = {square:F2}");
        return square;
    }

    public bool Equals(Rect? other)
    {
        if (other is null)
            return false;

        return this.Name == other.Name && this.CoordinateX1 == other.CoordinateX1
        && this.CoordinateY1 == other.CoordinateY1
        && this.CoordinateX2 == other.CoordinateX2
        && this.CoordinateY2 == other.CoordinateY2;
    }

    public override bool Equals(object? obj) => Equals(obj as Rect);

    public override int GetHashCode() => (Name, CoordinateX1, CoordinateY1, CoordinateX2, CoordinateY2).GetHashCode();
}

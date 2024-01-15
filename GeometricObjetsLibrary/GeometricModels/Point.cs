using System;

namespace GeometricObjetsLibrary.GeometricModels;

public class Point : GeometricModel, IEquatable<Point>
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
        Console.WriteLine($"{Name}: perimeter = {perimeter:F2}");
        return perimeter;
    }

    public override double Square()
    {
        double square = 0;
        Console.WriteLine($"{Name}: square = {square:F2}");
        return square;
    }

    public bool Equals(Point? other)
    {
        if (other is null)
            return false;

        return this.Name == other.Name && this.CoordinateX == other.CoordinateX
        && this.CoordinateY == other.CoordinateY;
    }

    public override bool Equals(object? obj) => Equals(obj as Point);

    public override int GetHashCode() => (Name, CoordinateX, CoordinateY).GetHashCode();
}

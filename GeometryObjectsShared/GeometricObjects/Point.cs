using GeometryObjectsShared;
using System;

namespace GeometricObjectsShared.GeometricObjects;

public class Point : IGeometricObject, IEquatable<Point>
{
    public double CoordinateX { get; set; }
    public double CoordinateY { get; set; }
    public string Name { get; set; } = "point";

    public Point(string[] data)
    {
        if (data.Length != 3
        || !double.TryParse(data[1], out double coordX)
        || !double.TryParse(data[2], out double coordY))
            throw new ArgumentException("Incorrect parameters for creating Point");
        CoordinateX = coordX;
        CoordinateY = coordY;
    }

    public void Draw() => Console.WriteLine(this.ToString());

    public double Perimeter()
    {
        double perimeter = 0;
        Console.WriteLine($"{Name}: perimeter = {perimeter:F2}");
        return perimeter;
    }

    public double Square()
    {
        double square = 0;
        Console.WriteLine($"{Name}: square = {square:F2}");
        return square;
    }

    public override string ToString() => String.Format($"{Name} at ({CoordinateX}, {CoordinateY})");

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

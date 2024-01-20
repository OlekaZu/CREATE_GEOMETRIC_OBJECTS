using GeometryObjectsShared;
using System;

namespace GeometricObjectsShared.GeometricObjects;

public class Line : IGeometricObject, IEquatable<Line>
{
    public Point PointOne { get; set; }
    public Point PointTwo { get; set; }
    public string Name { get; set; } = "line";

    public Line(string[] data)
    {
        if (data.Length != 5
        || !double.TryParse(data[1], out double coordX1)
        || !double.TryParse(data[2], out double coordY1)
        || !double.TryParse(data[3], out double coordX2)
        || !double.TryParse(data[4], out double coordY2))
            throw new ArgumentException("Incorrect parameters for creating Line");
        PointOne = new() { X = coordX1, Y = coordY1 };
        PointTwo = new() { X = coordX2, Y = coordY2 };
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

    public override string ToString() =>
    String.Format($"{Name} at ({PointOne.X}, {PointOne.Y}), ({PointTwo.X}, {PointTwo.Y})");

    public bool Equals(Line? other)
    {
        if (other is null)
            return false;

        return Name == other?.Name && PointOne.Equals(other?.PointOne)
        && PointTwo.Equals(other?.PointTwo);
    }

    public override bool Equals(object? obj) => Equals(obj as Line);

    public override int GetHashCode() => (Name, PointOne, PointTwo).GetHashCode();
}

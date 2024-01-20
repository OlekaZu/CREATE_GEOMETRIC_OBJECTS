using GeometryObjectsShared;
using System;

namespace GeometricObjectsShared.GeometricObjects;

public class Line : IGeometricObject, IEquatable<Line>
{
    public double CoordinateX1 { get; set; }
    public double CoordinateY1 { get; set; }
    public double CoordinateX2 { get; set; }
    public double CoordinateY2 { get; set; }
    public string Name { get; set; } = "line";

    public Line(string[] data)
    {
        if (data.Length != 5
        || !double.TryParse(data[1], out double coordX1)
        || !double.TryParse(data[2], out double coordY1)
        || !double.TryParse(data[3], out double coordX2)
        || !double.TryParse(data[4], out double coordY2))
            throw new ArgumentException("Incorrect parameters for creating Line");
        CoordinateX1 = coordX1;
        CoordinateY1 = coordY1;
        CoordinateX2 = coordX2;
        CoordinateY2 = coordY2;
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
    String.Format($"{Name} at ({CoordinateX1}, {CoordinateY1}), ({CoordinateX2}, {CoordinateY2})");

    public bool Equals(Line? other)
    {
        if (other is null)
            return false;

        return this.Name == other.Name && this.CoordinateX1 == other.CoordinateX1
        && this.CoordinateY1 == other.CoordinateY1
        && this.CoordinateX2 == other.CoordinateX2
        && this.CoordinateY2 == other.CoordinateY2;
    }

    public override bool Equals(object? obj) => Equals(obj as Line);

    public override int GetHashCode() => (Name, CoordinateX1, CoordinateY1, CoordinateX2, CoordinateY2).GetHashCode();
}

using GeometryObjectsShared;
using System;
using System.Reflection.Metadata;

namespace GeometricObjectsShared.GeometricObjects;

public class Rect : IGeometricObject, IEquatable<Rect>
{
    public double CoordinateX1 { get; set; }
    public double CoordinateY1 { get; set; }
    public double CoordinateX2 { get; set; }
    public double CoordinateY2 { get; set; }
    public string Name { get; set; } = "rect";

    public Rect(string[] data)
    {
        if (data.Length != 5
            || !double.TryParse(data[1], out double coordX1)
            || !double.TryParse(data[2], out double coordY1)
            || !double.TryParse(data[3], out double coordX2)
            || !double.TryParse(data[4], out double coordY2))
            throw new ArgumentException("Incorrect parameters for creating Rect");
        CoordinateX1 = coordX1;
        CoordinateY1 = coordY1;
        CoordinateX2 = coordX2;
        CoordinateY2 = coordY2;
    }

    public void Draw() => Console.WriteLine(this.ToString());

    public double Perimeter()
    {
        double perimeter = Math.Abs(CoordinateX2 - CoordinateX1) * 2 + Math.Abs(CoordinateY2 - CoordinateY1) * 2;
        Console.WriteLine($"{Name}: perimeter = {perimeter:F2}");
        return perimeter;
    }

    public double Square()
    {
        double square = Math.Abs(CoordinateX2 - CoordinateX1) * Math.Abs(CoordinateY2 - CoordinateY1);
        Console.WriteLine($"{Name}: square = {square:F2}");
        return square;
    }

    public override string ToString() =>
    String.Format($"{Name} at ({CoordinateX1}, {CoordinateY1}), ({CoordinateX2}, {CoordinateY2})");

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

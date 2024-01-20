using GeometricObjectsShared;
using GeometryObjectsShared;
using System;
using System.Reflection.Metadata;

namespace GeometricObjectsShared.GeometricObjects;

public class Circle : IGeometricObject, IEquatable<Circle>
{
    public Point Centre { get; set; }
    public double Radius { get; set; }
    public string Name { get; set; } = "circle";

    public Circle(string[] data)
    {
        if (data.Length != 4 || !double.TryParse(data[1], out double coordX)
          || !double.TryParse(data[2], out double coordY)
          || !double.TryParse(data[3], out double radius)
          || radius < 0)
            throw new ArgumentException("Incorrect parameters for creating Circle");
        Centre = new() { X = coordX, Y = coordY };
        Radius = radius;
    }

    public void Draw() => Console.WriteLine(this.ToString());

    public double Perimeter()
    {
        double perimeter = 2 * Math.PI * Radius;
        Console.WriteLine($"{Name}: perimeter = {perimeter:F2}");
        return perimeter;
    }

    public double Square()
    {
        double square = Math.PI * Math.Pow(Radius, 2);
        Console.WriteLine($"{Name}: square = {square:F2}");
        return square;
    }

    public override string ToString() => String.Format($"{Name} at ({Centre.X}, {Centre.Y}), radius = {Radius}");

    public bool Equals(Circle? other)
    {
        if (other is null)
            return false;

        return Name == other.Name && Centre.Equals(other.Centre)
        && Radius == other.Radius;
    }

    public override bool Equals(object? obj) => Equals(obj as Circle);

    public override int GetHashCode() => (Name, Centre, Radius).GetHashCode();
}

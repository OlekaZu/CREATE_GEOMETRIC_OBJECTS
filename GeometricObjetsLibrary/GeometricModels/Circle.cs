using System;
using System.Reflection.Metadata;

namespace GeometricObjetsLibrary.GeometricModels;

public class Circle : GeometricModel, IEquatable<Circle>
{
    public string? Name { get; set; }
    public double CoordinateX { get; set; }
    public double CoordinateY { get; set; }
    public double Radius { get; set; }

    public Circle() { }

    public override string ToString() => String.Format($"{Name} at ({CoordinateX}, {CoordinateY}), radius = {Radius}");

    public override void Draw() => Console.WriteLine(this.ToString());

    public override double Perimeter()
    {
        double perimeter = 2 * Math.PI * Radius;
        Console.WriteLine($"{Name}: perimeter = {perimeter:F2}");
        return perimeter;
    }

    public override double Square()
    {
        double square = Math.PI * Math.Pow(Radius, 2);
        Console.WriteLine($"{Name}: square = {square:F2}");
        return square;
    }

    public bool Equals(Circle? other)
    {
        if (other is null)
            return false;

        return this.Name == other.Name && this.CoordinateX == other.CoordinateX
        && this.CoordinateY == other.CoordinateY
        && this.Radius == other.Radius;
    }

    public override bool Equals(object? obj) => Equals(obj as Circle);

    public override int GetHashCode() => (Name, CoordinateX, CoordinateY, Radius).GetHashCode();
}

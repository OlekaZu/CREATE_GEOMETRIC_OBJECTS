using System;
using System.Reflection.Metadata;

namespace GeometricObjetsLibrary.GeometricModels;

public class Rhomb : GeometricModel, IEquatable<Rhomb>
{
    public string? Name { get; set; }
    public double CoordinateX { get; set; }
    public double CoordinateY { get; set; }
    public double Height { get; set; }
    public double Width { get; set; }

    public Rhomb() { }

    public override string ToString() =>
    String.Format($"{Name} at ({CoordinateX}, {CoordinateY}), height = {Height}, width = {Width}");

    public override void Draw() => Console.WriteLine(this.ToString());

    public override double Perimeter()
    {
        double perimeter = 4 * Math.Sqrt(Math.Pow(Height / 2, 2) + Math.Pow(Width / 2, 2));
        Console.WriteLine($"{Name}: perimeter = {perimeter:F2}");
        return perimeter;
    }

    public override double Square()
    {
        double square = Height * Width / 2;
        Console.WriteLine($"{Name}: square = {square:F2}");
        return square;
    }

    public bool Equals(Rhomb? other)
    {
        if (other is null)
            return false;

        return this.Name == other.Name && this.CoordinateX == other.CoordinateX
        && this.CoordinateY == other.CoordinateY
        && this.Height == other.Height
        && this.Width == other.Width;
    }

    public override bool Equals(object? obj) => Equals(obj as Rhomb);

    public override int GetHashCode() => (Name, CoordinateX, CoordinateY, Height, Width).GetHashCode();
}

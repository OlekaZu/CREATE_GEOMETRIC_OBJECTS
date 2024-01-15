using System;

namespace GeometricObjetsLibrary.GeometricModels;

public class FourSquare : GeometricModel, IEquatable<FourSquare>
{
    public string? Name { get; set; }
    public double CoordinateX { get; set; }
    public double CoordinateY { get; set; }
    public double Length { get; set; }

    public FourSquare() { }

    public override void Draw()
    {
        Console.WriteLine($"{Name} at ({CoordinateX}, {CoordinateY}), side length = {Length}");
    }

    public override double Perimeter()
    {
        double perimeter = 4 * Length;
        Console.WriteLine($"{Name}: perimeter = {perimeter:F2}");
        return perimeter;
    }

    public override double Square()
    {
        double square = Math.Pow(Length, 2);
        Console.WriteLine($"{Name}: square = {square:F2}");
        return square;
    }

    public bool Equals(FourSquare? other)
    {
        if (other is null)
            return false;

        return this.Name == other.Name && this.CoordinateX == other.CoordinateX
        && this.CoordinateY == other.CoordinateY
        && this.Length == other.Length;
    }

    public override bool Equals(object? obj) => Equals(obj as FourSquare);

    public override int GetHashCode() => (Name, CoordinateX, CoordinateY, Length).GetHashCode();
}

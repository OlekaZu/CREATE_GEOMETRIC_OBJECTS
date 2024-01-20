using GeometryObjectsShared;
using System;

namespace GeometricObjectsShared.GeometricObjects;

public class FourSquare : IGeometricObject, IEquatable<FourSquare>
{
    public double CoordinateX { get; set; }
    public double CoordinateY { get; set; }
    public double Length { get; set; }
    public string Name { get; set; } = "square";

    public FourSquare(string[] data)
    {
        if (data.Length != 4
            || !double.TryParse(data[1], out double coordX)
            || !double.TryParse(data[2], out double coordY)
            || !double.TryParse(data[3], out double length)
            || length < 0)
            throw new ArgumentException("Incorrect parameters for creating Square");
        CoordinateX = coordX;
        CoordinateY = coordY;
        Length = length;
    }

    public void Draw() => Console.WriteLine(this.ToString());

    public double Perimeter()
    {
        double perimeter = 4 * Length;
        Console.WriteLine($"{Name}: perimeter = {perimeter:F2}");
        return perimeter;
    }

    public double Square()
    {
        double square = Math.Pow(Length, 2);
        Console.WriteLine($"{Name}: square = {square:F2}");
        return square;
    }

    public override string ToString() => String.Format($"{Name} at ({CoordinateX}, {CoordinateY}), side length = {Length}");

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

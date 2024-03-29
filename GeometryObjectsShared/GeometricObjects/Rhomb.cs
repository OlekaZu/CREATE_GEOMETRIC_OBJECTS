﻿using GeometryObjectsShared;
using System;
using System.Reflection.Metadata;

namespace GeometricObjectsShared.GeometricObjects;

public class Rhomb : IGeometricObject, IEquatable<Rhomb>
{
    public Point Centre { get; set; }
    public double Height { get; set; }
    public double Width { get; set; }
    public string Name { get; set; } = "rhomb";

    public Rhomb(string[] data)
    {
        if (data.Length != 5
            || !double.TryParse(data[1], out double coordX)
            || !double.TryParse(data[2], out double coordY)
            || !double.TryParse(data[3], out double height)
            || !double.TryParse(data[4], out double width)
            || height < 0 || width < 0)
            throw new ArgumentException("Incorrect parameters for creating Rhomb");
        Centre = new() { X = coordX, Y = coordY };
        Height = height;
        Width = width;
    }

    public void Draw() => Console.WriteLine(this.ToString());

    public double Perimeter()
    {
        double perimeter = 4 * Math.Sqrt(Math.Pow(Height / 2, 2) + Math.Pow(Width / 2, 2));
        Console.WriteLine($"{Name}: perimeter = {perimeter:F2}");
        return perimeter;
    }

    public double Square()
    {
        double square = Height * Width / 2;
        Console.WriteLine($"{Name}: square = {square:F2}");
        return square;
    }

    public override string ToString() =>
    String.Format($"{Name} at ({Centre.X}, {Centre.Y}), height = {Height}, width = {Width}");

    public bool Equals(Rhomb? other)
    {
        if (other is null)
            return false;

        return Name == Name && Centre.Equals(other.Centre) && Height == other.Height
        && Width == other.Width;
    }

    public override bool Equals(object? obj) => Equals(obj as Rhomb);

    public override int GetHashCode() => (Name, Centre, Height, Width).GetHashCode();
}

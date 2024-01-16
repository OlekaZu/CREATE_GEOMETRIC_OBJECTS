﻿
using GeometricObjetsLibrary.GeometricModels;

namespace GeometricObjetsLibrary.Creators;

public class RectCreator : Creator
{
    private string[] _data;

    public RectCreator(string input) : base(input)
    {
        _data = input.Split();
    }

    public override GeometricModel Create()
    {
        if (_data.Length != 5 || !_data[0].Equals("rect")
        || !double.TryParse(_data[1], out double coordX1)
        || !double.TryParse(_data[2], out double coordY1)
        || !double.TryParse(_data[3], out double coordX2)
        || !double.TryParse(_data[4], out double coordY2))
            throw new ArgumentException("Incorrect parameters for creating Rect");

        return new Rect()
        {
            Name = _data[0],
            CoordinateX1 = coordX1,
            CoordinateY1 = coordY1,
            CoordinateX2 = coordX2,
            CoordinateY2 = coordY2
        };
    }
}

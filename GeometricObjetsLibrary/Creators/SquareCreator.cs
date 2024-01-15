
using GeometricObjetsLibrary.GeometricModels;

namespace GeometricObjetsLibrary.Creators;

public class SquareCreator : Creator
{
    private string[] _data;

    public SquareCreator(string input) : base(input)
    {
        _data = input.Split();
    }

    public override GeometricModel Create()
    {
        if (_data.Length != 4 || !_data[0].Equals("square")
        || !double.TryParse(_data[1], out double coordX)
        || !double.TryParse(_data[2], out double coordY)
        || !double.TryParse(_data[3], out double length))
            throw new ArgumentException("Incorrect parameters for creating Square");

        return new FourSquare()
        {
            Name = _data[0],
            CoordinateX = coordX,
            CoordinateY = coordY,
            Length = length
        };
    }
}

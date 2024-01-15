
using GeometricObjetsLibrary.GeometricModels;

namespace GeometricObjetsLibrary.Creators;

public class CircleCreator : Creator
{
    private string[] _data;

    public CircleCreator(string input) : base(input)
    {
        _data = input.Split();
    }

    public override GeometricModel Create()
    {
        if (_data.Length != 4 || !_data[0].Equals("circle")
        || !double.TryParse(_data[1], out double coordX)
        || !double.TryParse(_data[2], out double coordY)
        || !double.TryParse(_data[3], out double radius))
            throw new ArgumentException("Incorrect parameters for creating Circle");

        return new Circle()
        {
            Name = _data[0],
            CoordinateX = coordX,
            CoordinateY = coordY,
            Radius = radius
        };
    }
}

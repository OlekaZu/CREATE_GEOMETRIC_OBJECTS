
using GeometricObjetsLibrary.GeometricModels;

namespace GeometricObjetsLibrary.Creators;

public class LineCreator : Creator
{
    private string[] _data;

    public LineCreator(string input) : base(input)
    {
        _data = input.Split();
    }

    public override GeometricModel Create()
    {
        if (_data.Length != 5 || _data[0].Equals("line")
        || double.TryParse(_data[1], out double coordX1) == false
        || double.TryParse(_data[2], out double coordY1) == false
        || double.TryParse(_data[3], out double coordX2) == false
        || double.TryParse(_data[4], out double coordY2) == false)
            throw new ArgumentException("Incorrect parameters for creating Line");

        return new Line()
        {
            Name = _data[0],
            CoordinateX1 = coordX1,
            CoordinateY1 = coordY1,
            CoordinateX2 = coordX2,
            CoordinateY2 = coordY2
        };
    }
}

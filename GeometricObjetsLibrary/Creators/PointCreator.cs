using GeometricObjetsLibrary.GeometricModels;

namespace GeometricObjetsLibrary.Creators;

public class PointCreator : Creator
{
    private string[] _data;

    public PointCreator(string input) : base(input)
    {
        _data = input.Split();
    }

    public override GeometricModel Create()
    {
        if (_data.Length != 3 || _data[0].Equals("point")
        || double.TryParse(_data[1], out double coordX) == false
        || double.TryParse(_data[2], out double coordY) == false)
            throw new ArgumentException("Incorrect parameters for creating Point");

        return new Point()
        {
            Name = _data[0],
            CoordinateX = coordX,
            CoordinateY = coordY
        };
    }
}

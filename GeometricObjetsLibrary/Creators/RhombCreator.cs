
using GeometricObjetsLibrary.GeometricModels;

namespace GeometricObjetsLibrary.Creators;

public class RhombCreator : Creator
{
    private string[] _data;

    public RhombCreator(string input) : base(input)
    {
        _data = input.Split();
    }

    public override GeometricModel Create()
    {
        if (_data.Length != 5 || _data[0].Equals("rhomb")
        || double.TryParse(_data[1], out double coordX) == false
        || double.TryParse(_data[2], out double coordY) == false
        || double.TryParse(_data[3], out double height) == false
        || double.TryParse(_data[4], out double width) == false)
            throw new ArgumentException("Incorrect parameters for creating Rhomb");

        return new Rhomb()
        {
            Name = _data[0],
            CoordinateX = coordX,
            CoordinateY = coordY,
            Heigth = height,
            Width = width
        };
    }
}

using System.Globalization;

namespace GeometricObjetsLibrary;

public abstract class GeometricModel
{
    public GeometricModel()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
    }
    public abstract void Draw();
    public abstract double Perimeter();
    public abstract double Square();
}

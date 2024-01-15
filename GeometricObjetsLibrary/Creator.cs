using System.Globalization;

namespace GeometricObjetsLibrary;

public abstract class Creator
{
    public Creator(string input) { Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US"); }
    public abstract GeometricModel Create();
}

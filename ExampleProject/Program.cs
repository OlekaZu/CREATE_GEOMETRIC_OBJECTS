using GeometricObjetsLibrary;
using GeometricObjetsLibrary.Creators;

try
{
    Creator creator = new PointCreator("point 1 2");
    var myPoint = creator.Create();
    myPoint.Draw();
    myPoint.Perimeter();
    myPoint.Square();
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}




using GeometricObjetsLibrary;
using GeometricObjetsLibrary.Creators;

Creator creator = new PointCreator("point 1 2");
var myPoint = creator.Create();
myPoint.Draw();
myPoint.Perimeter();
myPoint.Square();



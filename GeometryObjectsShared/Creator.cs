using GeometricObjectsShared.GeometricObjects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Claims;
using System.Text;

namespace GeometryObjectsShared
{
    public static class Creator
    {
        //void IDisposable.Dispose() { }
        //public void Dispose() { GC.SuppressFinalize(this); }

        public static IGeometricObject CreateObject(string input)
        {
            var defaultCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            var data = input.Split();
            string firstWord = data[0];
            IGeometricObject creator = firstWord switch
            {
                "circle" => new Circle(data),
                "line" => new Line(data),
                "point" => new Point(data),
                "rhomb" => new Rhomb(data),
                "rect" => new Rect(data),
                "square" => new FourSquare(data),
                _ => throw new ArgumentException($"Unknown object")
            };
            Thread.CurrentThread.CurrentCulture = defaultCulture;
            return creator;
        }
    }
}

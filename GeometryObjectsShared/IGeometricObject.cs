using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryObjectsShared;

public interface IGeometricObject
{
    public string Name { get; set; }

    public void Draw();
    public double Perimeter();
    public double Square();
}


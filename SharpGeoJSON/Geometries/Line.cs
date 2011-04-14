using System;

namespace SharpGeoJSON.Geometries
{
    public class Line : Geometry<Double[][]>
    {
        public Line() : base(ObjectType.Line) { }
    }
}

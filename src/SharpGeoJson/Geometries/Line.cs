using System;

namespace SharpGeoJson.Geometries
{
    public class Line : Geometry<Double[][]>
    {
        public Line() : base(ObjectType.Line) { }
    }
}

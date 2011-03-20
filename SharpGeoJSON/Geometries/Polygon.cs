// Modified from original source by Joseph Phillips; 2011.
using System;

namespace SharpGeoJSON.Geometries
{
    /// <summary>The GeoJSON specification has polygon as an array of linear rings. Hence Double[][][].</summary>
    public class Polygon : Geometry<Double[][][]>
    {
        public Polygon() : base(ObjectType.Polygon) { }
    }
}

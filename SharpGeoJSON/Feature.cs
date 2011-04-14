// Modified from original Samu Lang source by Joseph Phillips; 2011.
// Add the specific geometry feature implementations to this file.
using Newtonsoft.Json;

namespace SharpGeoJSON
{
    public class Feature<TGeom, TProp> : GeoObject
    {
        [JsonProperty("geometry")]
        public TGeom Geometry { get; set; }

        [JsonProperty("properties")]
        public TProp Properties { get; set; }

        public Feature() : base(ObjectType.Feature) { }
    }

    public class PointFeature<T> : Feature<Geometries.Point, T> { }
    public class LineFeature<T> : Feature<Geometries.Line, T> { }
    public class PolygonFeature<T> : Feature<Geometries.Polygon, T> { }
}

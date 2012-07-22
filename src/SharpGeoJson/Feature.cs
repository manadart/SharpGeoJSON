
namespace SharpGeoJson
{
    public class Feature<TGeom, TProp> : GeoObject
    {
        public TGeom Geometry { get; set; }
        public TProp Properties { get; set; }

        public Feature() : base(ObjectType.Feature) { }
    }

    public class PointFeature<T> : Feature<Geometries.Point, T> { }
    public class LineFeature<T> : Feature<Geometries.Line, T> { }
    public class PolygonFeature<T> : Feature<Geometries.Polygon, T> { }
}

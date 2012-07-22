
namespace SharpGeoJson
{
    public class GeometryCollection<T> : GeoObject
    {
        public T[] Geometries { get; set; }

        public GeometryCollection() : base(ObjectType.GeometryCollection) { }
    }
}

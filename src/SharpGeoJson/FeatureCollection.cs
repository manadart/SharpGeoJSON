
namespace SharpGeoJson
{
    public class FeatureCollection<T> : GeoObject
    {
        public T[] Features { get; set; }

        public FeatureCollection() : base(ObjectType.FeatureCollection) { }
    }
}

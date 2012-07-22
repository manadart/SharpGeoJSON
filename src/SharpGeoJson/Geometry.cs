
namespace SharpGeoJson
{
    public abstract class Geometry<T> : GeoObject
    {
        public T Coordinates { get; set; }

        protected Geometry(ObjectType type) : base(type) { }
    }
}

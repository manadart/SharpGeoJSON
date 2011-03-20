// Modified from original source by Joseph Phillips; 2011.
using Newtonsoft.Json;

namespace SharpGeoJSON
{
    public abstract class Geometry<T> : GeoObject
    {
        [JsonProperty("coordinates")]
        public T Coordinates { get; set; }

        protected Geometry(ObjectType type) : base(type) { }
    }
}

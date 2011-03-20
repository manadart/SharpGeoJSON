// Modified from original Samu Lang source by Joseph Phillips; 2011.
using Newtonsoft.Json;

namespace SharpGeoJSON
{
    public class FeatureCollection<T> : GeoObject
    {
        [JsonProperty("features")]
        public T[] Features { get; set; }

        public FeatureCollection() : base(ObjectType.FeatureCollection) { }

    }
}

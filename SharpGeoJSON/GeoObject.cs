using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpGeoJSON
{
    public abstract class GeoObject
    {
        private ObjectType _type;

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public virtual ObjectType Type 
        {
            get { return _type; }
            set { _type = value; }
        }

        protected GeoObject(ObjectType type) { _type = type; }
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpGeoJSON
{
    public abstract class GeoObject
    {
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        private ObjectType _type;

        public virtual ObjectType Type 
        {
            get { return _type; }
            set { _type = value; }
        }

        protected GeoObject(ObjectType type) { _type = type; }
    }
}

using Newtonsoft.Json;

namespace SharpGeoJSON.UnitTests.TestTypes
{
    public class StreetCollection : FeatureCollection<Street>
    {
        [JsonProperty("street_collection_id")]
        public int CollectionId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Street : LineFeature<StreetProperties>
    {
        [JsonProperty("fid")]
        public int FeatureId { get; set; }
    }

    public class StreetProperties
    {
        [JsonProperty("street_name")]
        public string Name { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("post_code")]
        public string PostCode { get; set; }
    }
}

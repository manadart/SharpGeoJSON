
namespace SharpGeoJson.Test
{
    // Fairly simple line feature collection example.
    public class StreetCollection : FeatureCollection<Street>
    {
        public int CollectionId { get; set; }
        public string Name { get; set; }
    }

    public class Street : LineFeature<StreetProperties>
    {
        public int FeatureId { get; set; }
    }

    public class StreetProperties
    {
        public string Name { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpGeoJSON.UnitTests.TestTypes
{
    public class CompanySiteCollection : FeatureCollection<CompanySite>
    {
        [JsonProperty("company_id")]
        public int CompanyId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CompanySite : PointFeature<SiteProperties>
    {
        [JsonProperty("fid")]
        public int FeatureId { get; set; }
    }

    public class SiteProperties
    {
        [JsonProperty("site_id")]
        public int SiteId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("employees")]
        public List<EmployeeProperties> Employees { get; set; }
    }

    public class EmployeeProperties
    {
        [JsonProperty("employee_id")]
        public int EmployeeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }
    }
}

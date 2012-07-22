using System.Collections.Generic;

namespace SharpGeoJson.Test
{
    // Feature collection demonstrating some nesting of collections.
    public class CompanySiteCollection : FeatureCollection<CompanySite>
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
    }

    public class CompanySite : PointFeature<SiteProperties>
    {
        public int FeatureId { get; set; }
    }

    public class SiteProperties
    {
        public int SiteId { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public List<EmployeeProperties> Employees { get; set; }
    }

    public class EmployeeProperties
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Newtonsoft.Json;

namespace SharpGeoJSON.UnitTests
{
    public class FeatureCollectionTests
    {
        private const string CompanyJson = @"
{	
	""type"": ""FeatureCollection"",
	""company_id"": 1,
	""name"":""acme"",
	""features"": 
	[
		{
			""fid"":1,
			""properties"":
			{
				""site_id"":10,
				""address"":""somewhere"",
				""type"":""office"",
				""employees"":
				[
					{
						""employee_id"":33,
						""name"":""Mr. Johnson"",
						""position"":""Company Man""
					}
				]
			},
            ""geometry"": 
            {
                ""type"": ""Point"",
                ""coordinates"": [1, 2]
            }
		},
		{
			""fid"":2,
			""properties"":
			{
				""site_id"":11,
				""address"":""somewhere else"",
				""type"":""warehouse"",
				""employees"":
				[
					{
						""employee_id"":44,
						""name"":""Ronnie James Dio"",
						""position"":""Legend""
					},
                    {
						""employee_id"":55,
						""name"":""Chuck Schuldiner"",
						""position"":""Godfather""
					}
				]
			},
            ""geometry"": 
            {
                ""type"": ""Point"",
                ""coordinates"": [3, 4]
            }
		}
    ]
}";

        [Fact]
        public void TestPointFeatureCollection()
        {
            var collection = JsonConvert.DeserializeObject<CompanySiteCollection>(CompanyJson);

            Assert.Equal(2, collection.Features.Count());
            Assert.Equal(1, collection.CompanyId);
            Assert.Equal("acme", collection.Name);

            Assert.Equal(1, collection.Features[0].FeatureId);
            Assert.Equal(10, collection.Features[0].Properties.SiteId);
            Assert.Equal("somewhere", collection.Features[0].Properties.Address);
            Assert.Equal(1, collection.Features[0].Geometry.X);
            Assert.Equal(2, collection.Features[0].Geometry.Y);

            Assert.Equal(1, collection.Features[0].Properties.Employees.Count());
            Assert.Equal(33, collection.Features[0].Properties.Employees[0].EmployeeId);
            Assert.Equal("Mr. Johnson", collection.Features[0].Properties.Employees[0].Name);
            Assert.Equal("Company Man", collection.Features[0].Properties.Employees[0].Position);

            Assert.Equal(2, collection.Features[1].FeatureId);
            Assert.Equal(11, collection.Features[1].Properties.SiteId);
            Assert.Equal("somewhere else", collection.Features[1].Properties.Address);
            Assert.Equal(3, collection.Features[1].Geometry.X);
            Assert.Equal(4, collection.Features[1].Geometry.Y);

            Assert.Equal(2, collection.Features[1].Properties.Employees.Count());
            Assert.Equal(44, collection.Features[1].Properties.Employees[0].EmployeeId);
            Assert.Equal("Ronnie James Dio", collection.Features[1].Properties.Employees[0].Name);
            Assert.Equal("Legend", collection.Features[1].Properties.Employees[0].Position);
            Assert.Equal(55, collection.Features[1].Properties.Employees[1].EmployeeId);
            Assert.Equal("Chuck Schuldiner", collection.Features[1].Properties.Employees[1].Name);
            Assert.Equal("Godfather", collection.Features[1].Properties.Employees[1].Position);
        }
    }

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

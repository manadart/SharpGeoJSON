using System.Linq;
using SharpGeoJSON.UnitTests.TestTypes;
using Xunit;
using Newtonsoft.Json;

namespace SharpGeoJSON.UnitTests
{
    public class FeatureCollectionTests
    {
        [Fact]
        public void TestPointFeatureCollection()
        {
            var collection = JsonConvert.DeserializeObject<CompanySiteCollection>(TestJson.CompanyJsonPoint);

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

        [Fact]
        public void TestLineFeatureCollection()
        {
            var collection = JsonConvert.DeserializeObject<StreetCollection>(TestJson.StreetJsonLine);

            Assert.Equal(1, collection.Features.Count());
            Assert.Equal(1, collection.CollectionId);
            Assert.Equal("Sealed Roads", collection.Name);

            Assert.Equal(666, collection.Features[0].FeatureId);
            Assert.Equal("High Street", collection.Features[0].Properties.Name);
            Assert.Equal("Northcote", collection.Features[0].Properties.Suburb);
            Assert.Equal("Victoria", collection.Features[0].Properties.State);
            Assert.Equal("3070", collection.Features[0].Properties.PostCode);
            Assert.Equal(4, collection.Features[0].Geometry.Coordinates.Count());

            Assert.Equal(0, collection.Features[0].Geometry.Coordinates[0][0]);
            Assert.Equal(0, collection.Features[0].Geometry.Coordinates[0][1]);

            Assert.Equal(0, collection.Features[0].Geometry.Coordinates[1][0]);
            Assert.Equal(1, collection.Features[0].Geometry.Coordinates[1][1]);

            Assert.Equal(1, collection.Features[0].Geometry.Coordinates[2][0]);
            Assert.Equal(1, collection.Features[0].Geometry.Coordinates[2][1]);

            Assert.Equal(1, collection.Features[0].Geometry.Coordinates[3][0]);
            Assert.Equal(2, collection.Features[0].Geometry.Coordinates[3][1]);
        }
    }
}

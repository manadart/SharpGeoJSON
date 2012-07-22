
namespace SharpGeoJson.Test
{
    public static class TestJson
    {
        public const string CompanyJsonPoint = @"
{	
	""type"": ""FeatureCollection"",
	""companyId"": 1,
	""name"":""acme"",
	""features"": 
	[
		{
			""featureId"":1,
			""properties"":
			{
				""siteId"":10,
				""address"":""somewhere"",
				""type"":""office"",
				""employees"":
				[
					{
						""employeeId"":33,
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
			""featureId"":2,
			""properties"":
			{
				""siteId"":11,
				""address"":""somewhere else"",
				""type"":""warehouse"",
				""employees"":
				[
					{
						""employeeId"":44,
						""name"":""Ronnie James Dio"",
						""position"":""Legend""
					},
                    {
						""employeeId"":55,
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

        public const string StreetJsonLine = @"
{	
	""type"": ""FeatureCollection"",
	""collectionId"": 1,
	""name"":""Sealed Roads"",
	""features"": 
	[
		{
			""featureId"":666,
			""properties"":
			{
				""name"":""High Street"",
				""suburb"":""Northcote"",
                ""state"":""Victoria"",
				""postCode"":""3070""
			},
            ""geometry"": 
            {
                ""type"": ""Line"",
                ""coordinates"": [[0, 0], [0, 1], [1, 1], [1, 2]]
            }
		}
    ]
}";

    }
}

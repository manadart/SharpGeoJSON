using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpGeoJSON.UnitTests
{
    public static class TestJson
    {
        #region CompanyJsonPoint

        public const string CompanyJsonPoint = @"
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

        #endregion

        #region StreetJsonLine

        public const string StreetJsonLine = @"
{	
	""type"": ""FeatureCollection"",
	""street_collection_id"": 1,
	""name"":""Sealed Roads"",
	""features"": 
	[
		{
			""fid"":666,
			""properties"":
			{
				""street_name"":""High Street"",
				""suburb"":""Northcote"",
                ""state"":""Victoria"",
				""post_code"":""3070""
			},
            ""geometry"": 
            {
                ""type"": ""Line"",
                ""coordinates"": [[0, 0], [0, 1], [1, 1], [1, 2]]
            }
		}
    ]
}";

        #endregion
    }
}

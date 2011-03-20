﻿// Modified from original Samu Lang source by Joseph Phillips; 2011.
using Newtonsoft.Json;

namespace SharpGeoJSON
{
    public class Feature<TGeom, TProp> : GeoObject
    {
        [JsonProperty("geometry")]
        public TGeom Geometry { get; set; }

        [JsonProperty("properties")]
        public TProp Properties { get; set; }

        public Feature() : base(ObjectType.Feature) { }
    }
}
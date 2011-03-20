// Modified from original Samu Lang source by Joseph Phillips; 2011.
// The original used lat/lon and flipped the order to preseve the x/y format.
// This one just uses x and y in order to be coordinate system agnostic.
using System;
using Newtonsoft.Json;

namespace SharpGeoJSON.Geometries
{
    public class Point : Geometry<Double[]>
    {
        [JsonIgnore]
        public double X
        {
            get { return Coordinates[0]; }
            set { Coordinates[0] = value; }
        }

        [JsonIgnore]
        public double Y
        {
            get { return Coordinates[1]; }
            set { Coordinates[1] = value; }
        }

        public Point()
            : base(ObjectType.Point)
        {
            Coordinates = new double[] { 0, 0 };
        }

        public Point(double x, double y)
            : base(ObjectType.Point)
        {
            Coordinates = new [] { x, y };
        }

        public Point(string xy)
            : base(ObjectType.Point)
        {
            var coords = xy.Split(","[0]);
            Coordinates = new [] {double.Parse(coords[0]), double.Parse(coords[1])};
        }

        public override string ToString()
        {
            return string.Format("{0},{1}", X, Y);
        }
    }
}


using System;

namespace SharpGeoJson.Geometries
{
    public class Point : Geometry<Double[]>
    {
        public double X
        {
            get { return Coordinates[0]; }
            set { Coordinates[0] = value; }
        }

        public double Y
        {
            get { return Coordinates[1]; }
            set { Coordinates[1] = value; }
        }

        public Point() : base(ObjectType.Point)
        {
            Coordinates = new double[] { 0, 0 };
        }

        public Point(double x, double y) : base(ObjectType.Point)
        {
            Coordinates = new [] { x, y };
        }

        public Point(string xy) : base(ObjectType.Point)
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

// Modified from original Samu Lang source by Joseph Phillips; 2011.

namespace SharpGeoJson
{
    public abstract class GeoObject
    {
        private ObjectType _type;

        public virtual ObjectType Type 
        {
            get { return _type; }
            set { _type = value; }
        }

        protected GeoObject(ObjectType type) { _type = type; }
    }
}

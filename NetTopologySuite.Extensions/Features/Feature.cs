using GeoAPI.Extensions.Features;
using GeoAPI.Geometries;
using NetTopologySuite.Extensions.DataSources;

namespace NetTopologySuite.Extensions.Features
{
    public class Feature : IFeature
    {
        public Feature()
        {
            this.Attributes = new FeatureAttributeDictionary();
        }

        public Feature(IGeometry Geometry, params IFeatureAttribute[] Attributes)
        {

            this.Attributes = new FeatureAttributeDictionary();

            foreach (var attr in Attributes)
            {
                this.Attributes.Add(attr.Name, attr);
            }

            this.Geometry = Geometry;

        }

        public IGeometry Geometry { get; set; }

        public IFeatureAttributeDictionary Attributes { get; private set; }
    }
}
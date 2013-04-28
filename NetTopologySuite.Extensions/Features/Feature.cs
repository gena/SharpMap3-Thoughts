using GeoAPI.Extensions.Features;
using GeoAPI.Geometries;
using NetTopologySuite.Features;

namespace NetTopologySuite.Extensions.Features
{
    public class Feature : IFeature
    {
        public Feature()
        {
            Attributes = new FeatureAttributeDictionary(); 
        }

        public IGeometry Geometry { get; set; }

        public IFeatureAttributeDictionary Attributes { get; private set; }

        public IFeatureDataSource DataSource { get; private set; }
    }
}
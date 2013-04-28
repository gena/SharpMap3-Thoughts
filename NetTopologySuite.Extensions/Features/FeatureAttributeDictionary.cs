using System.Collections.Generic;
using GeoAPI.Extensions.Features;

namespace NetTopologySuite.Extensions.Features
{
    public class FeatureAttributeDictionary : Dictionary<string, object>, IFeatureAttributeDictionary
    {
        public FeatureAttributeDictionary()
        {
        }

        public FeatureAttributeDictionary(IFeatureDataSource dataSource)
        {
            DataSource = dataSource;
        }

        public IFeatureDataSource DataSource { get; private set; }
    }
}
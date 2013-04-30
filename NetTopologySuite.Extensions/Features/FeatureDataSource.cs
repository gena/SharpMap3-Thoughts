using System.Collections.Generic;
using System.Linq;
using GeoAPI.Extensions.Features;

namespace NetTopologySuite.Extensions.Features
{
    public abstract class FeatureDataSource : IFeatureDataSource
    {
        public IQueryable<IFeature> Features { get; set; }

        public FeatureDataSource()
        {
            Features = new List<IFeature>().AsQueryable<IFeature>();
        }
    }
}

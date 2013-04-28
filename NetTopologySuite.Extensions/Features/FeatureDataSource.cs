using System.Collections.Generic;
using System.Linq;
using GeoAPI.Extensions.Features;

namespace NetTopologySuite.Extensions.Features
{
    public abstract class FeatureDataSource : IFeatureDataSource
    {
        protected FeatureDataSource()
        {
            FeatureAttributes = new List<IFeatureAttribute>();
        }

        public IQueryable<IFeature> Features { get; set; }

        public IList<IFeatureAttribute> FeatureAttributes { get; private set; }
    }
}

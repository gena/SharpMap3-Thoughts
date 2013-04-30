using System.Collections.Generic;
using System.Linq;

namespace GeoAPI.Extensions.Features
{
    public interface IFeatureDataSource
    {
        /// <summary>
        /// List-based access to all features.
        /// </summary>
        IQueryable<IFeature> Features { get; set; }

        // IList<IFeatureAttribute> FeatureAttributes { get; } 

    }
}

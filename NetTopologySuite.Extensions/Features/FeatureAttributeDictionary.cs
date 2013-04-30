using System.Collections.Generic;
using GeoAPI.Extensions.Features;
using System.Linq;

namespace NetTopologySuite.Extensions.Features
{
    public class FeatureAttributeDictionary : Dictionary<string, IFeatureAttribute>, IFeatureAttributeDictionary
    {
    }
}
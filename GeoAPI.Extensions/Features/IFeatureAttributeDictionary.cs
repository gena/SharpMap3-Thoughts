using System.Collections.Generic;
using System.Linq;

namespace GeoAPI.Extensions.Features
{
    public interface IFeatureAttributeDictionary : IDictionary<string, IFeatureAttribute>
    {
    }
}
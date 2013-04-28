using System.Collections.Generic;

namespace GeoAPI.Extensions.Features
{
    public interface IFeatureAttributeDictionary : IDictionary<string, object>
    {
        IFeatureDataSource DataSource { get; }
    }
}
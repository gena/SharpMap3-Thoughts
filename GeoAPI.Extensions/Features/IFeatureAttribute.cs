using System;

namespace GeoAPI.Extensions.Features
{
    public interface IFeatureAttribute
    {
        string Name { get; set; }
        string Description { get; set; }
        //  Type ValueType { get; set; }
    }

    public interface IFeatureAttribute<T> : IFeatureAttribute
    {
        T Value { get; set; }
    }
}
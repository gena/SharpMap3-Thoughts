using System;

namespace GeoAPI.Extensions.Features
{
    public interface IFeatureAttribute : ICanSetValue
    {
        string Name { get; set; }
        string Description { get; set; }
        //  Type ValueType { get; set; }
    }

    public interface IFeatureAttribute<T> : IFeatureAttribute, IAttributeValue<T>
    {
        void SetValue(T Value);
    }
}
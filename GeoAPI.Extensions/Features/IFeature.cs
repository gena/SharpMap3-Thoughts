using GeoAPI.Geometries;

namespace GeoAPI.Extensions.Features
{
    public interface IFeature
    {
        IGeometry Geometry { get; set; }

        IFeatureAttributeDictionary Attributes { get; }
    }
}

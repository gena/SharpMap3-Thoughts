using System.Collections.Generic;
using System.Linq;
using GeoAPI.Extensions.Features;
using NetTopologySuite.Extensions.DataSources;
using NetTopologySuite.Extensions.Features;
using NetTopologySuite.Features;
using NetTopologySuite.Geometries;
using SharpTestsEx;
using Feature = NetTopologySuite.Extensions.Features.Feature;

namespace NetTopologySuite.Extensions.Tests.DataSources
{

    public class MemoryFeatureDataSourceTest
    {
        // create using simple feature. useful to read from Shapefile, other generic geospatial data source

        public void CreateUsingAnonymousConstructor()
        {
            var feature1 = new Feature { Geometry = new Point(0, 0, 0), Attributes = { { "Name", "Amsterdam" }, { "Population", 1500000 } } };
            var feature2 = new Feature { Geometry = new Point(1, 1, 1), Attributes = { { "Name", "The Hague" }, { "Population", 900000 } } };

            var dataSource = new MemoryFeatureDataSource { Features = new [] { feature1, feature2 }.AsQueryable() };

            dataSource.FeatureAttributes.Count
                      .Should("query attributes, automatically reconstructed from added features").Be.EqualTo(2);
        }

        // create using feature class

        public class City : Feature
        {
            [FeatureAttribute] public string Name { get; set; }
            [FeatureAttribute] public int Population { get; set; }
        }

        public void CreateUsingFeatureClass()
        {
            var city1 = new City { Geometry = new Point(0, 0, 0), Name = "Amsterdam", Population = 1500000 };
            var city2 = new City { Geometry = new Point(1, 1, 1), Name = "The Hague", Population = 9000000 };

            var cities = new [] { city1, city2 };

            var dataSource = new MemoryFeatureDataSource { Features = cities.AsQueryable() };
        
            dataSource.FeatureAttributes.Count
                     .Should("query attributes, automatically reconstructed from added features").Be.EqualTo(2);
        }
    }
}
using GeoAPI.Extensions.Features;
using System;
using System.Collections.Generic;

namespace NetTopologySuite.Extensions.Features
{

    public abstract class FeatureAttributeBase : IFeatureAttribute, ICanSetValue
    {

        private static Dictionary<Type, Func<string, string, IFeatureAttribute>> Factory = new Dictionary<Type, Func<string, string, IFeatureAttribute>>
        {
            {typeof(int),(x,y)=> new IntFeatureAttribute{Name=x,Description=y} },
            {typeof(float),(x,y)=> new FloatFeatureAttribute{Name=x,Description=y} },
            {typeof(double),(x,y)=> new DoubleFeatureAttribute{Name=x,Description=y} },
            {typeof(decimal),(x,y)=> new DecimalFeatureAttribute{Name=x,Description=y} },
            {typeof(DateTime),(x,y)=> new DateFeatureAttribute{Name=x,Description=y} },
            {typeof(string),(x,y)=> new StringFeatureAttribute{Name=x,Description=y} }
        };

        public string Name { get; set; }

        public string Description { get; set; }

        public static IFeatureAttribute<T> MakeAttribute<T>(string Name, string Description, T Value)
        {
            var output = Factory[typeof(T)].Invoke(Name, Description) as IFeatureAttribute<T>;
            output.Value = Value;
            return output;
        }

        public static IFeatureAttribute MakeAttribute(string Name, string Description, object Value)
        {
            var output = Factory[Value.GetType()].Invoke(Name, Description) as FeatureAttributeBase;
            output.SetValue(Value);
            return output;
        }

        public abstract void SetValue(object Value);
    }

    public class IntFeatureAttribute : FeatureAttributeBase, IFeatureAttribute<int>
    {
        public int Value { get; set; }

        public void SetValue(object Value)
        {
            this.Value = (int)Value;
        }

        public void SetValue(int Value)
        {
            this.Value = Value;
        }
    }

    public class FloatFeatureAttribute : FeatureAttributeBase, IFeatureAttribute<float>
    {
        public float Value { get; set; }

        public void SetValue(object Value)
        {
            SetValue((float)Value);
        }

        public void SetValue(float Value)
        {
            this.Value = Value;
        }
    }

    public class DoubleFeatureAttribute : FeatureAttributeBase, IFeatureAttribute<double>
    {
        public double Value { get; set; }

        public void SetValue(object Value)
        {
            SetValue((double)Value);
        }

        public void SetValue(double Value)
        {
            this.Value = Value;
        }
    }
    public class DecimalFeatureAttribute : FeatureAttributeBase, IFeatureAttribute<decimal>
    {
        public decimal Value { get; set; }

        public void SetValue(object Value)
        {
            SetValue((decimal)Value);
        }

        public void SetValue(decimal Value)
        {
            this.Value = Value;
        }
    }

    public class DateFeatureAttribute : FeatureAttributeBase, IFeatureAttribute<DateTime>
    {
        public DateTime Value { get; set; }

        public void SetValue(object Value)
        {
            SetValue((DateTime)Value);
        }

        public void SetValue(DateTime Value)
        {
            this.Value = Value;
        }
    }

    public class StringFeatureAttribute : FeatureAttributeBase, IFeatureAttribute<string>
    {
        public string Value { get; set; }

        public void SetValue(object Value)
        {
            SetValue((string)Value);
        }

        public void SetValue(string Value)
        {
            this.Value = Value;
        }
    }




}

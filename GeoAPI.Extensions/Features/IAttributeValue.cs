using System;

namespace GeoAPI.Extensions.Features
{
	public interface IAttributeValue<T> : ICanSetValue
	{
	    T Value { get; set; }
	}
}

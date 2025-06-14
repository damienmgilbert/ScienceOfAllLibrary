using System;
using System.Linq;
using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Time;

public interface ITime<T> : ITimeUnitType<T> where T : INumber<T>
{
    public ITime<T> ConvertFrom(TimeUnits units);
    public ITime<T> ConvertToBaseUnit(); // Method to convert the value to the base unit
    public ITime<T> ConvertTo(TimeUnits units); // Method to change the units of the physical unit
}

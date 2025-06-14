using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Length;

public interface ILength<T> : ILengthUnitType<T> where T : INumber<T>, new()
{
    public ILength<T> ConvertFrom(LengthUnits units);
    public ILength<T> ConvertToBaseUnit(); // Method to convert the value to the base unit
    public ILength<T> ConvertTo(LengthUnits units); // Method to change the units of the physical unit
}

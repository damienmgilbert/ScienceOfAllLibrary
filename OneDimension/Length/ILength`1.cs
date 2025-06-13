using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Length;

public interface ILength<T> where T : INumber<T>, new()
{
    public Length<T> ConvertFrom(LengthUnits units);
    public Length<T> ConvertToBaseUnit(); // Method to convert the value to the base unit
    public Length<T> ConvertTo(LengthUnits units); // Method to change the units of the physical unit
}

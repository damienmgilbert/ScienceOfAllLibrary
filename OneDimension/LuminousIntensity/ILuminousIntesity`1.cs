using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.LuminousIntensity;
public interface ILuminousIntesity<T> : ILuminousIntensityUnitType<T> where T : INumber<T>, new()
{
    public ILuminousIntesity<T> ConvertFrom(LuminousIntensityUnits units);
    public ILuminousIntesity<T> ConvertToBaseUnit(); // Method to convert the value to the base unit
    public ILuminousIntesity<T> ConvertTo(LuminousIntensityUnits units); // Method to change the units of the physical unit
}

using System;
using System.Linq;
using System.Numerics;

namespace ScienceOfAllLibrary.TwoDimensions.Speed;

public interface IVelocity<T> : IVelocityUnitType<T> where T : INumber<T>, new()
{
    public IVelocity<T> ConvertFrom(VelocityUnits units);
    public IVelocity<T> ConvertToBaseUnit(); // Method to convert the value to the base unit
    public IVelocity<T> ConvertTo(VelocityUnits units); // Method to change the units of the physical unit
}
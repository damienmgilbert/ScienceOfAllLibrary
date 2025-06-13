using System;
using System.Linq;
using System.Numerics;


namespace ScienceOfAllLibrary.OneDimension.Units;

public abstract class PhysicalUnit<T, E> : BaseUnitType<E>, IPhysicalUnit<T, E> where E : Enum where T : INumber<T>, new()
{
    public abstract T Value { get; set; } // Value of the unit, e.g., 5 for 5 meters, 10 for 10 kilograms, etc.
}

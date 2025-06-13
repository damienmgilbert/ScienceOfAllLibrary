using System;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;

using ScienceOfAllLibrary.Core;

namespace ScienceOfAllLibrary.OneDimension.Units;

public interface IPhysicalUnit<T, E> :  IObservableObject, IBaseUnitType<E> where E : Enum  where T : INumber<T>, new()
{
    T Value { get; set; } // Value of the unit, e.g., 5 for 5 meters, 10 for 10 kilograms, etc.
}

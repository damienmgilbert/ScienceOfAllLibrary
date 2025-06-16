using System;
using System.Linq;
using System.Numerics;

namespace ScienceOfAllLibrary.Core.Units.BaseUnits.Times;

public interface ITimeUnits<TValue> : IPhysicalUnitBase<TValue, TimeUnit> where TValue : INumber<TValue>, new()
{
}
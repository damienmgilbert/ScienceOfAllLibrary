
using ScienceOfAllLibrary.Core.Prefixes;

using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.Core.Units.BaseUnits;

public interface IPhysicalUnitBase<TValue, TUnits> where TValue : INumber<TValue>, new() where TUnits : Enum
{
    string Definition { get; }
    string Dimension { get; }
    string Name { get; }
    IPrefix Prefix { get; }
    string QuantityName { get; }
    string Symbol { get; }
    TUnits Units { get; set; }
    TValue Value { get; set; }
}


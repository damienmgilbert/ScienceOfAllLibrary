using System;
using System.Linq;
using System.Numerics;

using ScienceOfAllLibrary.Core.Prefixes;
using ScienceOfAllLibrary.Core.Units.BaseUnits.Lengths;

namespace ScienceOfAllLibrary.Core.Units.BaseUnits;

public abstract class PhysicalUnitBase<TValue, TUnits> : IPhysicalUnitBase<TValue, TUnits>
where TValue : INumber<TValue>, new() where TUnits : Enum
{

    protected PhysicalUnitBase(TValue value,  TUnits units)
    {
        Value = value;
        Units = units;
    }

    public abstract string Name { get; }
    public abstract string Symbol { get; }
    public abstract string Dimension { get; }
    public abstract string QuantityName { get; }
    public abstract string Definition { get; }
    public abstract TUnits Units { get; set; }
    public abstract IPrefix Prefix { get; set; }
    public abstract TValue Value { get; set; }
}


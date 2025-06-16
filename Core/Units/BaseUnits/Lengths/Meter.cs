using System;
using System.Linq;
using System.Numerics;

using ScienceOfAllLibrary.Core.Prefixes;

namespace ScienceOfAllLibrary.Core.Units.BaseUnits.Lengths;

public class Meter<TValue> : PhysicalUnitBase<TValue, LengthUnit> where TValue : INumber<TValue>, new()
{
    public Meter(TValue value, LengthUnit units) : base(value, units)
    {

    }

    public override string Name => "Metre";
    public override string Symbol => "m";
    public override string Dimension => "L";
    public override string QuantityName => "Length";
    public override string Definition => "The distance travelled by light in vacuum in 1/299792458 second.";

    public override LengthUnit Units { get; set; } = LengthUnit.Meter;
    public override IPrefix Prefix { get; set; } = new NoPrefix();
    public override TValue Value { get; set; }
}

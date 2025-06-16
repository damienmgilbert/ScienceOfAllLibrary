using System;
using System.Linq;
using System.Numerics;

using ScienceOfAllLibrary.Core.Prefixes;

namespace ScienceOfAllLibrary.Core.Units.BaseUnits.Masses;

public class Kilogram<TValue> : PhysicalUnitBase<TValue, MassUnit> where TValue : INumber<TValue>, new()
{
    public Kilogram(TValue value, MassUnit units) : base(value, units)
    {

    }

    public override string Name => "Kilogram";
    public override string Symbol => "kg";
    public override string Dimension => "M";
    public override string QuantityName => "Mass";
    public override string Definition => "Defined by setting the Planck constant h to 6.62607015×10⁻³⁴ J⋅s (J = kg⋅m²⋅s⁻²).";

    public override MassUnit Units { get; set; } = MassUnit.Kilogram;
    public override IPrefix Prefix { get; set; } = new NoPrefix();
    public override TValue Value { get; set; }
}

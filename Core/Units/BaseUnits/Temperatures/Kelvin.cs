using System;
using System.Linq;
using System.Numerics;

using ScienceOfAllLibrary.Core.Prefixes;

namespace ScienceOfAllLibrary.Core.Units.BaseUnits.Temperatures;

public class Kelvin<TValue> : PhysicalUnitBase<TValue, TemperatureUnit> where TValue : INumber<TValue>, new()
{
    public Kelvin(TValue value, TemperatureUnit units) : base(value, units)
    {

    }

    public override string Name => "Kelvin";
    public override string Symbol => "K";
    public override string Dimension => "Θ";
    public override string QuantityName => "Thermodynamic Temperature";
    public override string Definition => "Defined by setting the fixed numerical value of the Boltzmann constant k to 1.380649×10⁻²³ J⋅K⁻¹ (J = kg⋅m²⋅s⁻²).";
    public override TemperatureUnit Units { get; set; } = TemperatureUnit.Kelvin;
    public override IPrefix Prefix { get; set; } = new NoPrefix();
    public override TValue Value { get; set; }
}

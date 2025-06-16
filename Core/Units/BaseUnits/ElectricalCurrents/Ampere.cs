using System;
using System.Linq;
using System.Numerics;

using ScienceOfAllLibrary.Core.Prefixes;

namespace ScienceOfAllLibrary.Core.Units.BaseUnits.ElectricalCurrents;

public class Ampere<TValue> : PhysicalUnitBase<TValue, ElectricalCurrentUnit> where TValue : INumber<TValue>, new()
{
    public Ampere(TValue value, ElectricalCurrentUnit units) : base(value, units)
    {

    }

    public override string Name => "Ampere";
    public override string Symbol => "A";
    public override string Dimension => "I";
    public override string QuantityName => "Electric Current";
    public override string Definition => "The flow of 1/1.602176634×10⁻¹⁹ times the elementary charge e per second, approximately 6.2415090744×10¹⁸ elementary charges per second.";

    public override ElectricalCurrentUnit Units { get; set; } = ElectricalCurrentUnit.Ampere;
    public override IPrefix Prefix { get; set; } = new NoPrefix();
    public override TValue Value { get; set; }
}

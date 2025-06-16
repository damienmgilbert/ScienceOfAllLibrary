using System;
using System.Linq;
using System.Numerics;

using ScienceOfAllLibrary.Core.Prefixes;

namespace ScienceOfAllLibrary.Core.Units.BaseUnits.LuminousIntensities;

public class Candela<TValue> : PhysicalUnitBase<TValue, LuminousIntensityUnit> where TValue : INumber<TValue>, new()
{
    public Candela(TValue value, LuminousIntensityUnit units) : base(value, units)
    {

    }

    public override string Name => "Candela";
    public override string Symbol => "cd";
    public override string Dimension => "J";
    public override string QuantityName => "Luminous Intensity";
    public override string Definition => "The luminous intensity of a source emitting monochromatic radiation of frequency 5.4×10¹⁴ Hz with a radiant intensity of 1/683 watt per steradian.";
    public override LuminousIntensityUnit Units {get;set;} = LuminousIntensityUnit.Candela;
    public override IPrefix Prefix {get;set;} = new NoPrefix();
    public override TValue Value {get;set;}
}
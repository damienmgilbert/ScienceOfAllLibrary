using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Units;

public class Kilogram : PhysicalUnitBase
{
    public override string Name => "Kilogram";
    public override string Symbol => "kg";
    public override string Dimension => "M";
    public override string QuantityName => "Mass";
    public override string Definition => "Defined by setting the Planck constant h to 6.62607015×10⁻³⁴ J⋅s (J = kg⋅m²⋅s⁻²).";
}

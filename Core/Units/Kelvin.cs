using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Units;

public class Kelvin : PhysicalUnitBase
{
    public override string Name => "Kelvin";
    public override string Symbol => "K";
    public override string Dimension => "Θ";
    public override string QuantityName => "Thermodynamic Temperature";
    public override string Definition => "Defined by setting the fixed numerical value of the Boltzmann constant k to 1.380649×10⁻²³ J⋅K⁻¹ (J = kg⋅m²⋅s⁻²).";
}

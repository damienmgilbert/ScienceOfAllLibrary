using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Units;

public class Ampere : PhysicalUnitBase
{
    public override string Name => "Ampere";
    public override string Symbol => "A";
    public override string Dimension => "I";
    public override string QuantityName => "Electric Current";
    public override string Definition => "The flow of 1/1.602176634×10⁻¹⁹ times the elementary charge e per second, approximately 6.2415090744×10¹⁸ elementary charges per second.";
}

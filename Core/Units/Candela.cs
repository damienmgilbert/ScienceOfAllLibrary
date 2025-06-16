using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Units;

public class Candela : PhysicalUnitBase
{
    public override string Name => "Candela";
    public override string Symbol => "cd";
    public override string Dimension => "J";
    public override string QuantityName => "Luminous Intensity";
    public override string Definition => "The luminous intensity of a source emitting monochromatic radiation of frequency 5.4×10¹⁴ Hz with a radiant intensity of 1/683 watt per steradian.";
}
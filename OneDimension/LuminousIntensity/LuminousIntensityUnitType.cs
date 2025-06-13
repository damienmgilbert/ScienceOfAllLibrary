using ScienceOfAllLibrary.OneDimension.Units;

using System;

using System.Linq;

namespace ScienceOfAllLibrary.OneDimension.LuminousIntensity;

public class LuminousIntensityUnitType : BaseUnitType<LuminousIntensityUnits>
{
    public override LuminousIntensityUnits Units { get; set; } = LuminousIntensityUnits.Candela; // Default unit is Candela
    public override string Name { get; set; } = "Luminous Intensity";
    public override string Symbol { get; set; } = "cd"; // Symbol for candela
    public override string Description { get; set; } = "Unit of luminous intensity in the International System of Units (SI).";
    public override LuminousIntensityUnits BaseUnit { get; set; } = LuminousIntensityUnits.Candela;
}

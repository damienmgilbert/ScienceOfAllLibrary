using System;
using System.Linq;

using ScienceOfAllLibrary.OneDimension.Units;

namespace ScienceOfAllLibrary.OneDimension.Length;

public class LengthUnitType : BaseUnitType<LengthUnits>
{
    public override LengthUnits Units { get; set; } = LengthUnits.Meter; // Default unit is Meter
    public override string Name { get; set; } = "Length";
    public override string Symbol { get; set; } = "m"; // Symbol for meters
    public override string Description { get; set; } = "Unit of length in the metric system.";
    public override LengthUnits BaseUnit { get; set; } = LengthUnits.Meter;
}


using ScienceOfAllLibrary.OneDimension.Units;

using System;

using System.Linq;

namespace ScienceOfAllLibrary.TwoDimensions.Surface;

public class AreaUnitType : BaseUnitType<AreaUnits>
{
    public override AreaUnits Units { get; set; } = AreaUnits.SquareMeter; // Default unit is Square Meter
    public override string Name { get; set; } = "Area";
    public override string Symbol { get; set; } = "m²"; // Symbol for square meters
    public override string Description { get; set; } = "Unit of area in the metric system.";
    public override AreaUnits BaseUnit { get; set; } = AreaUnits.SquareMeter; // Base unit for area is Square Meter
}

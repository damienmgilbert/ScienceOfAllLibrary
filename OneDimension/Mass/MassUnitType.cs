using ScienceOfAllLibrary.OneDimension.Units;

using System;

using System.Linq;

namespace ScienceOfAllLibrary.OneDimension.Mass;

public class MassUnitType : BaseUnitType<MassUnits>
{
    public override MassUnits Units { get; set; } = MassUnits.Grams; // Default unit is Grams
    public override string Name { get; set; } = "Mass";
    public override string Symbol { get; set; } = "g"; // Symbol for grams
    public override string Description { get; set; } = "Unit of mass in the metric system.";
    public override MassUnits BaseUnit { get; set; } = MassUnits.Grams;
}



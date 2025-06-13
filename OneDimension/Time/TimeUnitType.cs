using ScienceOfAllLibrary.OneDimension.Units;

using System;

using System.Linq;

namespace ScienceOfAllLibrary.OneDimension.Time;

public class TimeUnitType : BaseUnitType<TimeUnits>
{
    public override TimeUnits Units { get; set; } = TimeUnits.Second; // Default unit is Second
    public override string Name { get; set; } = "Time";
    public override string Symbol { get; set; } = "s"; // Symbol for seconds
    public override string Description { get; set; } = "Unit of time in the metric system.";
    public override TimeUnits BaseUnit { get; set; } = TimeUnits.Second;
}

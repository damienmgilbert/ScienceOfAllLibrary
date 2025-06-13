using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;

namespace ScienceOfAllLibrary.TwoDimensions.Speed;

public class VelocityUnitType : BaseUnitType<VelocityUnits>
{
    public override VelocityUnits Units { get; set; } = VelocityUnits.MetersPerSecond; // Default unit is MetersPerSecond
    public override string Name { get; set; } = "Velocity";
    public override string Symbol { get; set; } = "m/s"; // Symbol for meters per second
    public override string Description { get; set; } = "Unit of velocity in the metric system.";
    public override VelocityUnits BaseUnit { get; set; } = VelocityUnits.MetersPerSecond;
}

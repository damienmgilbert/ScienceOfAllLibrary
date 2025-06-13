using ScienceOfAllLibrary.OneDimension.Units;

using System;

using System.Linq;

namespace ScienceOfAllLibrary.OneDimension.Temperature;


public class TemperatureUnitType : BaseUnitType<TemperatureUnits>
{
    public override TemperatureUnits Units { get; set; } = TemperatureUnits.Celsius; // Default unit is Celsius
    public override string Name { get; set; } = "Temperature";
    public override string Symbol { get; set; } = "°C"; // Symbol for Celsius
    public override string Description { get; set; } = "Unit of temperature in the metric system.";
    public override TemperatureUnits BaseUnit { get; set; } = TemperatureUnits.Celsius;
}

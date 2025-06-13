using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Temperature;

public class Temperature<T> : PhysicalUnit<T, TemperatureUnits> where T : INumber<T>, new()
{
    public override T Value { get; set; } = T.Zero; // Default value is zero
    public override TemperatureUnits Units { get; set; } = TemperatureUnits.Celsius; // Default unit is Celsius
    public override string Name { get; set; } = "Temperature";
    public override string Symbol { get; set; } = "°C"; // Symbol for Celsius
    public override string Description { get; set; } = "Unit of temperature in the metric system.";
    public override TemperatureUnits BaseUnit { get; set; } = TemperatureUnits.Celsius; // Base unit for temperature is Celsius
    public Temperature(T value)
    {
        Value = value; // Initialize with a value
    }
    public Temperature(T value, TemperatureUnits units) : this(value)
    {
        Units = units;
    }
    public override T ConvertToBaseUnit()
    {
        return Units switch
        {
            TemperatureUnits.Celsius => Value, // No conversion needed for base unit
            TemperatureUnits.Fahrenheit => (Value - T.CreateChecked(32)) * T.CreateChecked(5) / T.CreateChecked(9), // Convert Fahrenheit to Celsius
            TemperatureUnits.Kelvin => Value - T.CreateChecked(273.15), // Convert Kelvin to Celsius
            TemperatureUnits.Rankine => (Value - T.CreateChecked(491.67)) * T.CreateChecked(5) / T.CreateChecked(9), // Convert Rankine to Celsius
            _ => throw new NotImplementedException($"Conversion from {Units} to base unit is not implemented.")
        };
    }
    public override void ConvertToUnits(TemperatureUnits newUnits)
    {
        if (newUnits == Units) return; // No conversion needed if the units are the same
        // Convert current value to base unit first
        T baseValue = ConvertToBaseUnit();
        // Then convert from base unit to the new units
        Value = newUnits switch
        {
            TemperatureUnits.Celsius => baseValue, // No conversion needed for base unit
            TemperatureUnits.Fahrenheit => baseValue * T.CreateChecked(9) / T.CreateChecked(5) + T.CreateChecked(32), // Convert Celsius to Fahrenheit
            TemperatureUnits.Kelvin => baseValue + T.CreateChecked(273.15), // Convert Celsius to Kelvin
            TemperatureUnits.Rankine => baseValue * T.CreateChecked(9) / T.CreateChecked(5) + T.CreateChecked(491.67), // Convert Celsius to Rankine
            _ => throw new NotImplementedException($"Conversion to {newUnits} is not implemented.")
        };
        Units = newUnits; // Update the units after conversion
    }
}
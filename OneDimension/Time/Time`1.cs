using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Time;

public class Time<T> : PhysicalUnit<T, TimeUnits> where T : INumber<T>, new()
{
    public override T Value { get; set; } = T.Zero; // Default value is zero
    public override TimeUnits Units { get; set; } = TimeUnits.Second; // Default unit is Second
    public override string Name { get; set; } = "Time";
    public override string Symbol { get; set; } = "s"; // Symbol for seconds
    public override string Description { get; set; } = "Unit of time in the metric system.";
    public override TimeUnits BaseUnit { get; set; } = TimeUnits.Second;
    public Time(T value)
    {
        Value = value; // Initialize with a value
    }
    public Time(T value, TimeUnits units) : this(value)
    {
        Units = units;
    }
    public override T ConvertToBaseUnit()
    {
        return Units switch
        {
            TimeUnits.Second => Value, // No conversion needed for base unit
            TimeUnits.Minute => Value * T.CreateChecked(60), // Convert minutes to seconds
            TimeUnits.Hour => Value * T.CreateChecked(3600), // Convert hours to seconds
            TimeUnits.Day => Value * T.CreateChecked(86400), // Convert days to seconds
            TimeUnits.Week => Value * T.CreateChecked(604800), // Convert weeks to seconds
            TimeUnits.Month => Value * T.CreateChecked(2628000), // Approx. 30.44 days in seconds
            TimeUnits.Year => Value * T.CreateChecked(31536000), // Approx. 365.25 days in seconds
            _ => throw new NotImplementedException($"Conversion from {Units} to base unit is not implemented.")
        };
    }
    public override void ConvertToUnits(TimeUnits newUnits)
    {
        if (newUnits == Units) return; // No conversion needed if the units are the same
        // Convert current value to base unit first
        T baseValue = ConvertToBaseUnit();
        // Then convert from base unit to the new units
        Value = newUnits switch
        {
            TimeUnits.Second => baseValue, // No conversion needed for base unit
            TimeUnits.Minute => baseValue / T.CreateChecked(60), // Convert seconds to minutes
            TimeUnits.Hour => baseValue / T.CreateChecked(3600), // Convert seconds
            TimeUnits.Day => baseValue / T.CreateChecked(86400), // Convert seconds to days
            TimeUnits.Week => baseValue / T.CreateChecked(604800), // Convert seconds to weeks
            TimeUnits.Month => baseValue / T.CreateChecked(2628000), // Approx. 30.44 days in seconds
            TimeUnits.Year => baseValue / T.CreateChecked(31536000), // Approx. 365.25 days in seconds
            _ => throw new NotImplementedException($"Conversion to {newUnits} is not implemented.")
        };
        Units = newUnits; // Update the units after conversion
    }
}
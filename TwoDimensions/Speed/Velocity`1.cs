using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;
using System.Numerics;

namespace ScienceOfAllLibrary.TwoDimensions.Speed;

public class Velocity<T> : PhysicalUnit<T, VelocityUnits> where T : INumber<T>, new()
{
    public override T Value { get; set; } = T.Zero; // Default value is zero
    public override VelocityUnits Units { get; set; } = VelocityUnits.MetersPerSecond; // Default unit is MetersPerSecond
    public override string Name { get; set; } = "Velocity";
    public override string Symbol { get; set; } = "m/s"; // Symbol for meters per second
    public override string Description { get; set; } = "Unit of velocity in the metric system.";
    public override VelocityUnits BaseUnit { get; set; } = VelocityUnits.MetersPerSecond;
    public Velocity(T value)
    {
        Value = value; // Initialize with a value
    }
    public Velocity(T value, VelocityUnits units) : this(value)
    {
        Units = units;
    }
    public override T ConvertToBaseUnit()
    {
        return Units switch
        {
            VelocityUnits.MetersPerSecond => Value, // No conversion needed for base unit
            VelocityUnits.KilometersPerHour => Value / T.CreateChecked(3.6), // Convert km/h to m/s
            VelocityUnits.MilesPerHour => Value / T.CreateChecked(2.236936), // Convert mph to m/s
            VelocityUnits.FeetPerSecond => Value / T.CreateChecked(3.28084), // Convert ft/s to m/s
            VelocityUnits.Knots => Value / T.CreateChecked(1.943844), // Convert knots to m/s
            VelocityUnits.CentimetersPerSecond => Value / T.CreateChecked(100), // Convert cm/s to m/s
            VelocityUnits.MillimetersPerSecond => Value / T.CreateChecked(1000), // Convert mm/s to m/s
            VelocityUnits.InchesPerSecond => Value / T.CreateChecked(39.3701), // Convert in/s to m/s
            _ => throw new NotImplementedException($"Conversion from {Units} to base unit is not implemented.")
        };
    }
    public override void ConvertToUnits(VelocityUnits newUnits)
    {
        if (newUnits == Units) return; // No conversion needed if the units are the same
        // Convert current value to base unit first
        T baseValue = ConvertToBaseUnit();

        // Then convert from base unit to the new units
        Value = newUnits switch
        {
            VelocityUnits.MetersPerSecond => baseValue, // No conversion needed for base unit
            VelocityUnits.KilometersPerHour => baseValue * T.CreateChecked(3.6), // Convert m/s to km/h
            VelocityUnits.MilesPerHour => baseValue * T.CreateChecked(2.236936), // Convert m/s to mph
            VelocityUnits.FeetPerSecond => baseValue * T.CreateChecked(3.28084), // Convert m/s to ft/s
            VelocityUnits.Knots => baseValue * T.CreateChecked(1.943844), // Convert m/s to knots
            VelocityUnits.CentimetersPerSecond => baseValue * T.CreateChecked(100), // Convert m/s to cm/s
            VelocityUnits.MillimetersPerSecond => baseValue * T.CreateChecked(1000), // Convert m/s to mm/s
            VelocityUnits.InchesPerSecond => baseValue * T.CreateChecked(39.3701), // Convert m/s to in/s
            _ => throw new NotImplementedException($"Conversion to {newUnits} is not implemented.")
        };
        Units = newUnits; // Update the units after conversion
    }
}
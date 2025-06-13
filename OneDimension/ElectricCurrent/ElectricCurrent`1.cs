using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.ElectricCurrent;

public class ElectricCurrent<T> : PhysicalUnit<T, ElectricCurrentUnits> where T : INumber<T>, new()
{
    public override T Value { get; set; } = T.Zero; // Default value is zero
    public override ElectricCurrentUnits Units { get; set; } = ElectricCurrentUnits.Ampere; // Default unit is Ampere
    public override string Name { get; set; } = "Electric Current";
    public override string Symbol { get; set; } = "A"; // Symbol for amperes
    public override string Description { get; set; } = "Unit of electric current in the International System of Units (SI).";
    public override ElectricCurrentUnits BaseUnit { get; set; } = ElectricCurrentUnits.Ampere;
    public ElectricCurrent(T value)
    {
        Value = value; // Initialize with a value
    }
    public ElectricCurrent(T value, ElectricCurrentUnits units) : this(value)
    {
        Units = units;
    }
    public override T ConvertToBaseUnit()
    {
        return Units switch
        {
            ElectricCurrentUnits.Ampere => Value, // No conversion needed for base unit
            ElectricCurrentUnits.Milliampere => Value / T.CreateChecked(1000), // Convert milliamperes to amperes
            ElectricCurrentUnits.Microampere => Value / T.CreateChecked(1000000), // Convert microamperes to amperes
            ElectricCurrentUnits.Kiloampere => Value * T.CreateChecked(1000), // Convert kiloamperes to amperes
            ElectricCurrentUnits.Megaampere => Value * T.CreateChecked(1000000), // Convert megaamperes to amperes
            _ => throw new NotImplementedException($"Conversion from {Units} to base unit is not implemented.")
        };
    }
    public override void ConvertToUnits(ElectricCurrentUnits newUnits)
    {
        if (newUnits == Units) return; // No conversion needed if the units are the same
        // Convert current value to base unit first
        T baseValue = ConvertToBaseUnit();
        // Then convert from base unit to the new units
        Value = newUnits switch
        {
            ElectricCurrentUnits.Ampere => baseValue, // No conversion needed for base unit
            ElectricCurrentUnits.Milliampere => baseValue * T.CreateChecked(1000), // Convert amperes to milliamperes
            ElectricCurrentUnits.Microampere => baseValue * T.CreateChecked(1000000), // Convert amperes to microamperes
            ElectricCurrentUnits.Kiloampere => baseValue / T.CreateChecked(1000), // Convert amperes to kiloamperes
            ElectricCurrentUnits.Megaampere => baseValue / T.CreateChecked(1000000), // Convert amperes to megaamperes
            _ => throw new NotImplementedException($"Conversion to {newUnits} is not implemented.")
        };
        Units = newUnits; // Update the units after conversion
    }
}
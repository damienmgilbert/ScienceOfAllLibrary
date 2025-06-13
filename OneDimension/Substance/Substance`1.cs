using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Substance;

public class Substance<T> : PhysicalUnit<T, SubstanceUnits> where T : INumber<T>, new()
{
    public override T Value { get; set; } = T.Zero; // Default value is zero
    public override SubstanceUnits Units { get; set; } = SubstanceUnits.Mole; // Default unit is Mole
    public override string Name { get; set; } = "Substance";
    public override string Symbol { get; set; } = "mol"; // Symbol for moles
    public override string Description { get; set; } = "Unit of amount of substance in the International System of Units (SI).";
    public override SubstanceUnits BaseUnit { get; set; } = SubstanceUnits.Mole; // Base unit for substance is Mole
    public Substance(T value)
    {
        Value = value; // Initialize with a value
    }
    public Substance(T value, SubstanceUnits units) : this(value)
    {
        Units = units;
    }
    public override T ConvertToBaseUnit()
    {
        return Units switch
        {
            SubstanceUnits.Mole => Value, // No conversion needed for base unit
            SubstanceUnits.Millimole => Value / T.CreateChecked(1000), // Convert millimoles to moles
            SubstanceUnits.Micromole => Value / T.CreateChecked(1_000_000), // Convert micromoles to moles
            SubstanceUnits.Kilomole => Value * T.CreateChecked(1000), // Convert kilomoles to moles
            SubstanceUnits.Megamole => Value * T.CreateChecked(1_000_000), // Convert megamoles to moles
            _ => throw new NotImplementedException($"Conversion from {Units} to base unit is not implemented.")
        };
    }
    public override void ConvertToUnits(SubstanceUnits newUnits)
    {
        if (newUnits == Units) return; // No conversion needed if the units are the same
        // Convert current value to base unit first
        T baseValue = ConvertToBaseUnit();
        // Then convert from base unit to the new units
        Value = newUnits switch
        {
            SubstanceUnits.Mole => baseValue, // No conversion needed for base unit
            SubstanceUnits.Millimole => baseValue * T.CreateChecked(1000), // Convert moles to millimoles
            SubstanceUnits.Micromole => baseValue * T.CreateChecked(1_000_000), // Convert moles to micromoles
            SubstanceUnits.Kilomole => baseValue / T.CreateChecked(1000), // Convert moles to kilomoles
            SubstanceUnits.Megamole => baseValue / T.CreateChecked(1_000_000), // Convert moles to megamoles
            _ => throw new NotImplementedException($"Conversion to {newUnits} is not implemented.")
        };
        Units = newUnits; // Update the units after conversion
    }
}
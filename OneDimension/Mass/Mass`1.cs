using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Mass;

public class Mass<T> : PhysicalUnit<T, MassUnits> where T : INumber<T>, new()
{
    public override T Value { get; set; } = T.Zero; // Default value is zero
    public override MassUnits Units { get; set; } = MassUnits.Grams; // Default unit is Grams
    public override string Name { get; set; } = "Mass";
    public override string Symbol { get; set; } = "g"; // Symbol for grams
    public override string Description { get; set; } = "Unit of mass in the metric system.";
    public override MassUnits BaseUnit { get; set; } = MassUnits.Grams; // Base unit for mass is Grams
    public Mass(T value)
    {
        Value = value; // Initialize with a value
    }
    public Mass(T value, MassUnits units) : this(value)
    {
        Units = units;
    }

    public override T ConvertToBaseUnit()
    {
        return Units switch
        {
            MassUnits.Grams => Value, // No conversion needed for base unit
            MassUnits.Kilograms => Value * T.CreateChecked(1000), // Convert kilograms to grams
            MassUnits.Milligrams => Value / T.CreateChecked(1000), // Convert milligrams to grams
            MassUnits.Micrograms => Value / T.CreateChecked(1_000_000), // Convert micrograms to grams
            MassUnits.MetricTons => Value * T.CreateChecked(1_000_000), // Convert metric tons to grams
            MassUnits.Ounces => Value * T.CreateChecked(28.3495), // Convert ounces to grams
            MassUnits.Pounds => Value * T.CreateChecked(453.592), // Convert pounds to grams
            MassUnits.Stones => Value * T.CreateChecked(6350.29), // Convert stones to grams
            MassUnits.ImperialTons => Value * T.CreateChecked(1016046.91), // Convert imperial tons to grams
            MassUnits.USShortTons => Value * T.CreateChecked(907184.74), // Convert US short tons to grams
            MassUnits.USLongTons => Value * T.CreateChecked(1016046.91), // Convert US long tons to grams
            _ => throw new NotImplementedException($"Conversion from {Units} to base unit is not implemented.")
        };
    }

    public override void ConvertToUnits(MassUnits newUnits)
    {
        if (newUnits == Units) return; // No conversion needed if the units are the same
        // Convert current value to base unit first
        T baseValue = ConvertToBaseUnit();
        // Then convert from base unit to the new units
        Value = newUnits switch
        {
            MassUnits.Grams => baseValue, // No conversion needed for base unit
            MassUnits.Kilograms => baseValue / T.CreateChecked(1000), // Convert grams to kilograms
            MassUnits.Milligrams => baseValue * T.CreateChecked(1000), // Convert grams to milligrams
            MassUnits.Micrograms => baseValue * T.CreateChecked(1_000_000), // Convert grams to micrograms
            MassUnits.MetricTons => baseValue / T.CreateChecked(1_000_000), // Convert grams to metric tons
            MassUnits.Ounces => baseValue / T.CreateChecked(28.3495), // Convert grams to ounces
            MassUnits.Pounds => baseValue / T.CreateChecked(453.592), // Convert grams to pounds
            MassUnits.Stones => baseValue / T.CreateChecked(6350.29), // Convert grams to stones
            MassUnits.ImperialTons => baseValue / T.CreateChecked(1016046.91), // Convert grams to imperial tons
            MassUnits.USShortTons => baseValue / T.CreateChecked(907184.74), // Convert grams to US short tons
            MassUnits.USLongTons => baseValue / T.CreateChecked(1016046.91), // Convert grams to US long tons
            _ => throw new NotImplementedException($"Conversion to {newUnits} is not implemented.")
        };
        Units = newUnits; // Update the units after conversion
    }
}

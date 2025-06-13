
using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.TwoDimensions.Surface;

public class Area<T> : PhysicalUnit<T, AreaUnits> where T : INumber<T>, new()
{
    public override T Value { get; set; } = T.Zero; // Default value is zero
    public override AreaUnits Units { get; set; } = AreaUnits.SquareMeter; // Default unit is Square Meter
    public override string Name { get; set; } = "Area";
    public override string Symbol { get; set; } = "m²"; // Symbol for square meters
    public override string Description { get; set; } = "Unit of area in the metric system.";
    public override AreaUnits BaseUnit { get; set; } = AreaUnits.SquareMeter; // Base unit for area is Square Meter
    public Area(T value)
    {
        Value = value; // Initialize with a value
    }
    public Area(T value, AreaUnits units) : this(value)
    {
        Units = units;
    }
    public override T ConvertToBaseUnit()
    {
        return Units switch
        {
            AreaUnits.SquareMeter => Value, // No conversion needed for base unit
            AreaUnits.SquareKilometer => Value * T.CreateChecked(1_000_000), // Convert square kilometers to square meters
            AreaUnits.SquareCentimeter => Value / T.CreateChecked(10_000), // Convert square centimeters to square meters
            AreaUnits.SquareMillimeter => Value / T.CreateChecked(1_000_000), // Convert square millimeters to square meters
            AreaUnits.SquareInch => Value * T.CreateChecked(0.00064516), // Convert square inches to square meters
            AreaUnits.SquareFoot => Value * T.CreateChecked(0.092903), // Convert square feet to square meters
            AreaUnits.SquareYard => Value * T.CreateChecked(0.836127), // Convert square yards to square meters
            AreaUnits.Hectare => Value * T.CreateChecked(10_000), // Convert hectares to square meters
            AreaUnits.Acre => Value * T.CreateChecked(4046.86), // Convert acres to square meters
            AreaUnits.SquareMile => Value * T.CreateChecked(2_589_988), // Convert square miles to square meters
            AreaUnits.SquareDecimeter => Value / T.CreateChecked(100), // Convert square decimeters to square meters
            AreaUnits.SquareMicrometer => Value / T.CreateChecked(1_000_000_000), // Convert square micrometers to square meters
            AreaUnits.SquareNanometer => Value / T.CreateChecked(1_000_000_000_000_000), // Convert square nanometers to square meters
            AreaUnits.SquarePicometer => Value / T.CreateChecked(1_000_000_000_000_000_000), // Convert square picometers to square meters
            _ => throw new NotImplementedException($"Conversion from {Units} to base unit is not implemented.")
        };
    }
    public override void ConvertToUnits(AreaUnits newUnits)
    {
        if (newUnits == Units) return; // No conversion needed if the units are the same
        // Convert current value to base unit first
        T baseValue = ConvertToBaseUnit();
        // Then convert from base unit to the new units
        Value = newUnits switch
        {
            AreaUnits.SquareMeter => baseValue, // No conversion needed for base unit
            AreaUnits.SquareKilometer => baseValue / T.CreateChecked(1_000_000), // Convert square meters to square kilometers
            AreaUnits.SquareCentimeter => baseValue * T.CreateChecked(10_000), // Convert square meters to square centimeters
            AreaUnits.SquareMillimeter => baseValue * T.CreateChecked(1_000_000), // Convert square meters to square millimeters
            AreaUnits.SquareInch => baseValue / T.CreateChecked(0.00064516), // Convert square meters to square inches
            AreaUnits.SquareFoot => baseValue / T.CreateChecked(0.092903), // Convert square meters to square feet
            AreaUnits.SquareYard => baseValue / T.CreateChecked(0.836127), // Convert square meters to square yards
            AreaUnits.Hectare => baseValue / T.CreateChecked(10_000), // Convert square meters to hectares
            AreaUnits.Acre => baseValue / T.CreateChecked(4046.86), // Convert square meters to acres
            AreaUnits.SquareMile => baseValue / T.CreateChecked(2_589_988), // Convert square meters to square miles
            AreaUnits.SquareDecimeter => baseValue * T.CreateChecked(100), // Convert square meters to square decimeters
            AreaUnits.SquareMicrometer => baseValue * T.CreateChecked(1_000_000_000), // Convert square meters to square micrometers
            AreaUnits.SquareNanometer => baseValue * T.CreateChecked(1_000_000_000_000_000), // Convert square meters to square nanometers
            AreaUnits.SquarePicometer => baseValue * T.CreateChecked(1_000_000_000_000_000_000), // Convert square meters to square picometers
            _ => throw new NotImplementedException($"Conversion to {newUnits} is not implemented.")
        };
        Units = newUnits; // Update the units after conversion
    }
}
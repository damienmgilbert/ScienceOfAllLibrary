using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.LuminousIntensity;

public class LuminousIntensity<T> : PhysicalUnit<T, LuminousIntensityUnits> where T : INumber<T>, new()
{
    public override T Value { get; set; } = T.Zero; // Default value is zero
    public override LuminousIntensityUnits Units { get; set; } = LuminousIntensityUnits.Candela; // Default unit is Candela
    public override string Name { get; set; } = "Luminous Intensity";
    public override string Symbol { get; set; } = "cd"; // Symbol for candela
    public override string Description { get; set; } = "Unit of luminous intensity in the International System of Units (SI).";
    public override LuminousIntensityUnits BaseUnit { get; set; } = LuminousIntensityUnits.Candela;
    public LuminousIntensity(T value)
    {
        Value = value; // Initialize with a value
    }
    public LuminousIntensity(T value, LuminousIntensityUnits units) : this(value)
    {
        Units = units;
    }
    public override T ConvertToBaseUnit()
    {
        return Units switch
        {
            LuminousIntensityUnits.Candela => Value, // No conversion needed for base unit
            LuminousIntensityUnits.LumenPerSteradian => Value / T.CreateChecked(1), // Conversion logic for Lumen per Steradian (1 cd = 1 lm/sr)
            LuminousIntensityUnits.Nit => Value / T.CreateChecked(1), // Conversion logic for Nit (1 cd/m² = 1 nit)
            LuminousIntensityUnits.Lumen => Value / T.CreateChecked(1), // Conversion logic for Lumen (1 cd = 1 lm)
            _ => throw new NotImplementedException($"Conversion from {Units} to base unit is not implemented.")
        };
    }
    public override void ConvertToUnits(LuminousIntensityUnits newUnits)
    {
        if (newUnits == Units) return; // No conversion needed if the units are the same
        // For luminous intensity, only Candela is the base unit, so no conversion logic needed for other units
        T baseValue = ConvertToBaseUnit(); // Convert to base unit first
        Value = newUnits switch
        {
            LuminousIntensityUnits.Candela => baseValue, // No conversion needed for base unit
            LuminousIntensityUnits.LumenPerSteradian => baseValue * T.CreateChecked(1), // Convert from Candela to Lumen per Steradian (1 cd = 1 lm/sr)
            LuminousIntensityUnits.Nit => baseValue * T.CreateChecked(1), // Convert from Candela to Nit (1 cd/m² = 1 nit)
            LuminousIntensityUnits.Lumen => baseValue * T.CreateChecked(1), // Convert from Candela to Lumen (1 cd = 1 lm)
            _ => throw new NotImplementedException($"Conversion to {newUnits} is not implemented.")
        };
        Units = newUnits; // Update the units after conversion
    }
}
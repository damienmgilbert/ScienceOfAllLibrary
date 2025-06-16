//-----------------------------------------------------------------------
// <copyright file="LuminousIntensity`1.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.LuminousIntensity;
public class LuminousIntensity<T> : BaseUnitType<T, LuminousIntensityUnits>, ILuminousIntesity<T> where T : INumber<T>, new()
{

    #region Constructors
    public LuminousIntensity()
    {

    }
    public LuminousIntensity(T value)
    {
        Value = value; // Initialize with a value
    }
    public LuminousIntensity(T value, LuminousIntensityUnits units) : this(value)
    {
        Units = units;
    }
    #endregion

    #region Public methods
    public ILuminousIntesity<T> ConvertFrom(LuminousIntensityUnits units)
    {
        var baseValue = ConvertToBaseUnit(); // Ensure the value is in base unit before conversion
        return units switch
        {
            LuminousIntensityUnits.Candela => new LuminousIntensity<T> { Value = baseValue.Value, Units = LuminousIntensityUnits.Candela },
            LuminousIntensityUnits.LumenPerSteradian => new LuminousIntensity<T> { Value = baseValue.Value * T.CreateChecked(4 * Math.PI), Units = LuminousIntensityUnits.LumenPerSteradian },
            LuminousIntensityUnits.Nit => new LuminousIntensity<T> { Value = baseValue.Value * T.CreateChecked(Math.PI), Units = LuminousIntensityUnits.Nit },
            _ => throw new NotImplementedException($"Conversion from {units} to base unit is not implemented.")
        };
    }
    public ILuminousIntesity<T> ConvertTo(LuminousIntensityUnits units)
    {
        var baseValue = ConvertToBaseUnit(); // Ensure the value is in base unit before conversion
        return units switch
        {
            LuminousIntensityUnits.Candela => new LuminousIntensity<T> { Value = baseValue.Value, Units = LuminousIntensityUnits.Candela },
            LuminousIntensityUnits.LumenPerSteradian => new LuminousIntensity<T> { Value = baseValue.Value * T.CreateChecked(4 * Math.PI), Units = LuminousIntensityUnits.LumenPerSteradian },
            LuminousIntensityUnits.Nit => new LuminousIntensity<T> { Value = baseValue.Value * T.CreateChecked(Math.PI), Units = LuminousIntensityUnits.Nit },
            _ => throw new NotImplementedException($"Conversion to {units} is not implemented.")
        };
    }
    public ILuminousIntesity<T> ConvertToBaseUnit()
    {
        return Units switch
        {
            LuminousIntensityUnits.Candela => new LuminousIntensity<T> { Value = Value, Units = LuminousIntensityUnits.Candela },
            LuminousIntensityUnits.LumenPerSteradian => new LuminousIntensity<T> { Value = Value / T.CreateChecked(4 * Math.PI), Units = LuminousIntensityUnits.Candela },
            LuminousIntensityUnits.Nit => new LuminousIntensity<T> { Value = Value / T.CreateChecked(Math.PI), Units = LuminousIntensityUnits.Candela },
            _ => throw new NotImplementedException($"Conversion from {Units} to base unit is not implemented.")
        };
    }
    #endregion

    #region Public properties
    public override LuminousIntensityUnits BaseUnit { get; set; } = LuminousIntensityUnits.Candela;
    public override string Description { get; set; } = "Unit of luminous intensity in the International System of Units (SI).";
    public override DimensionType Dimension { get; set; } = DimensionType.LuminousIntensity; // Dimension type for luminous intensity
    public override string Name { get; set; } = "Luminous Intensity";
    public override string Symbol { get; set; } = "cd"; // Symbol for candela
    public override LuminousIntensityUnits Units { get; set; } = LuminousIntensityUnits.Candela; // Default unit is Candela
    public override T Value { get; set; } = T.Zero; // Default value is zero
    #endregion

}
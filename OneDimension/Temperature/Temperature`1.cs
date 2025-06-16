//-----------------------------------------------------------------------
// <copyright file="Temperature`1.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Temperature;
public class Temperature<T> : BaseUnitType<T, TemperatureUnits>, ITemperature<T> where T : INumber<T>, new()
{

    #region Constructors
    public Temperature() { } // Default constructor
    public Temperature(T value)
    {
        Value = value; // Initialize with a value
    }
    public Temperature(T value, TemperatureUnits units) : this(value)
    {
        Units = units;
    }
    #endregion

    #region Public methods
    public ITemperature<T> ConvertFromUnits(TemperatureUnits units)
    {
        var baseValue = ConvertToBaseUnit().Value;
        return units switch
        {
            TemperatureUnits.Celsius => new Temperature<T>(baseValue, TemperatureUnits.Celsius),
            TemperatureUnits.Fahrenheit => new Temperature<T>(baseValue * T.CreateChecked(1.8) + T.One, TemperatureUnits.Fahrenheit),
            TemperatureUnits.Kelvin => new Temperature<T>(baseValue + T.CreateChecked(273.15), TemperatureUnits.Kelvin),
            _ => throw new NotSupportedException($"Conversion from {units} to {Units} is not supported.")
        };
    }
    public ITemperature<T> ConvertToBaseUnit()
    {
        return Units switch
        {
            TemperatureUnits.Celsius => this,
            TemperatureUnits.Fahrenheit => new Temperature<T>((Value - T.One) * T.CreateChecked(1.8), TemperatureUnits.Celsius),
            TemperatureUnits.Kelvin => new Temperature<T>(Value - T.CreateChecked(273.15), TemperatureUnits.Celsius),
            _ => throw new NotSupportedException($"Conversion from {Units} to Celsius is not supported.")
        };
    }
    public ITemperature<T> ConvertToUnits(TemperatureUnits units)
    {
        var baseValue = ConvertToBaseUnit().Value;
        return units switch
        {
            TemperatureUnits.Celsius => new Temperature<T>(baseValue, TemperatureUnits.Celsius),
            TemperatureUnits.Fahrenheit => new Temperature<T>(baseValue * T.CreateChecked(1.8) + T.One, TemperatureUnits.Fahrenheit),
            TemperatureUnits.Kelvin => new Temperature<T>(baseValue + T.CreateChecked(273.15), TemperatureUnits.Kelvin),
            _ => throw new NotSupportedException($"Conversion from {Units} to {units} is not supported.")
        };
    }
    #endregion

    #region Public properties
    public override TemperatureUnits BaseUnit { get; set; } = TemperatureUnits.Celsius; // Base unit for temperature is Celsius
    public override string Description { get; set; } = "Unit of temperature in the metric system.";
    public override DimensionType Dimension { get; set; } = DimensionType.Temperature; // Dimension type for temperature
    public override string Name { get; set; } = "Temperature";
    public override string Symbol { get; set; } = "°C"; // Symbol for Celsius
    public override TemperatureUnits Units { get; set; } = TemperatureUnits.Celsius; // Default unit is Celsius
    public override T Value { get; set; } = T.Zero; // Default value is zero
    #endregion

}
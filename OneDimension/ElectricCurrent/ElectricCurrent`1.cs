//-----------------------------------------------------------------------
// <copyright file="ElectricCurrent`1.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.ElectricCurrent;
public class ElectricCurrent<T> : BaseUnitType<T, ElectricCurrentUnits>, IElectricCurrent<T> where T : INumber<T>, new()
{

    #region Constructors
    public ElectricCurrent()
    {
        // Default constructor
    }
    public ElectricCurrent(T value)
    {
        Value = value; // Initialize with a value
    }
    public ElectricCurrent(T value, ElectricCurrentUnits units) : this(value)
    {
        Units = units;
    }
    #endregion

    #region Public methods
    public IElectricCurrent<T> ConvertFrom(ElectricCurrentUnits units)
    {
        var baseValue = ConvertToBaseUnit(); // Ensure the value is in base unit before conversion
        return units switch
        {
            ElectricCurrentUnits.Ampere => new ElectricCurrent<T> { Value = baseValue.Value, Units = ElectricCurrentUnits.Ampere },
            ElectricCurrentUnits.Milliampere => new ElectricCurrent<T> { Value = baseValue.Value * T.CreateChecked(1000), Units = ElectricCurrentUnits.Milliampere },
            ElectricCurrentUnits.Kiloampere => new ElectricCurrent<T> { Value = baseValue.Value / T.CreateChecked(1000), Units = ElectricCurrentUnits.Kiloampere },
            _ => throw new NotImplementedException($"Conversion from {units} to base unit is not implemented.")
        };
    }
    public IElectricCurrent<T> ConvertTo(ElectricCurrentUnits units)
    {
        var baseValue = ConvertToBaseUnit(); // Ensure the value is in base unit before conversion
        return units switch
        {
            ElectricCurrentUnits.Ampere => new ElectricCurrent<T> { Value = baseValue.Value, Units = ElectricCurrentUnits.Ampere },
            ElectricCurrentUnits.Milliampere => new ElectricCurrent<T> { Value = baseValue.Value / T.CreateChecked(1000), Units = ElectricCurrentUnits.Milliampere },
            ElectricCurrentUnits.Kiloampere => new ElectricCurrent<T> { Value = baseValue.Value * T.CreateChecked(1000), Units = ElectricCurrentUnits.Kiloampere },
            _ => throw new NotImplementedException($"Conversion to {units} is not implemented.")
        };
    }
    public IElectricCurrent<T> ConvertToBaseUnit()
    {
        return Units switch
        {
            ElectricCurrentUnits.Ampere => new ElectricCurrent<T> { Value = Value, Units = ElectricCurrentUnits.Ampere },
            ElectricCurrentUnits.Milliampere => new ElectricCurrent<T> { Value = Value / T.CreateChecked(1000), Units = ElectricCurrentUnits.Milliampere },
            ElectricCurrentUnits.Kiloampere => new ElectricCurrent<T> { Value = Value * T.CreateChecked(1000), Units = ElectricCurrentUnits.Kiloampere },
            _ => throw new NotImplementedException($"Conversion from {Units} to base unit is not implemented.")
        };
    }
    #endregion

    #region Public properties
    public override ElectricCurrentUnits BaseUnit { get; set; } = ElectricCurrentUnits.Ampere;
    public override string Description { get; set; } = "Unit of electric current in the International System of Units (SI).";
    public override DimensionType Dimension { get; set; } = DimensionType.ElectricCurrent;
    public override string Name { get; set; } = "Electric Current";
    public override string Symbol { get; set; } = "A"; // Symbol for amperes
    public override ElectricCurrentUnits Units { get; set; } = ElectricCurrentUnits.Ampere; // Default unit is Ampere
    public override T Value { get; set; } = T.Zero; // Default value is zero
    #endregion

}
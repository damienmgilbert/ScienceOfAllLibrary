//-----------------------------------------------------------------------
// <copyright file="Time`1.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using ScienceOfAllLibrary.OneDimension.Mass;
using ScienceOfAllLibrary.OneDimension.Units;

using System;

using System.Linq;
using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Time;
public class Time<T> : BaseUnitType<T, TimeUnits>, ITime<T> where T : INumber<T>, new()
{

    #region Constructors
    public Time()
    {
        // Default constructor
    }
    public Time(T value)
    {
        Value = value; // Initialize with a value
    }
    public Time(T value, TimeUnits units) : this(value)
    {
        Units = units;
    }
    #endregion

    #region Public methods
    public ITime<T> ConvertFrom(TimeUnits units)
    {
        var baseTime = ConvertToBaseUnit(); // Convert to base unit (seconds)
        return units switch
        {
            TimeUnits.Second => new Time<T> { Value = baseTime.Value, Units = TimeUnits.Second },
            TimeUnits.Minute => new Time<T> { Value = baseTime.Value / T.CreateChecked(60), Units = TimeUnits.Minute },
            TimeUnits.Hour => new Time<T> { Value = baseTime.Value / T.CreateChecked(3600), Units = TimeUnits.Hour },
            TimeUnits.Day => new Time<T> { Value = baseTime.Value / T.CreateChecked(86400), Units = TimeUnits.Day },
            TimeUnits.Week => new Time<T> { Value = baseTime.Value / T.CreateChecked(604800), Units = TimeUnits.Week },
            TimeUnits.Month => new Time<T> { Value = baseTime.Value / T.CreateChecked(2.628e+6), Units = TimeUnits.Month }, // Approx. 30.44 days
            TimeUnits.Year => new Time<T> { Value = baseTime.Value / T.CreateChecked(3.154e+7), Units = TimeUnits.Year }, // Approx. 365.25 days
            _ => throw new NotImplementedException("Conversion for the specified unit is not implemented.")
        };
    }
    public ITime<T> ConvertTo(TimeUnits units)
    {
        var baseTime = ConvertToBaseUnit(); // Convert to base unit (seconds)
        return units switch
        {
            TimeUnits.Second => new Time<T> { Value = baseTime.Value, Units = TimeUnits.Second },
            TimeUnits.Minute => new Time<T> { Value = baseTime.Value / T.CreateChecked(60), Units = TimeUnits.Minute },
            TimeUnits.Hour => new Time<T> { Value = baseTime.Value / T.CreateChecked(3600), Units = TimeUnits.Hour },
            TimeUnits.Day => new Time<T> { Value = baseTime.Value / T.CreateChecked(86400), Units = TimeUnits.Day },
            TimeUnits.Week => new Time<T> { Value = baseTime.Value / T.CreateChecked(604800), Units = TimeUnits.Week },
            TimeUnits.Month => new Time<T> { Value = baseTime.Value / T.CreateChecked(2.628e+6), Units = TimeUnits.Month }, // Approx. 30.44 days
            TimeUnits.Year => new Time<T> { Value = baseTime.Value / T.CreateChecked(3.154e+7), Units = TimeUnits.Year }, // Approx. 365.25 days
            _ => throw new NotImplementedException("Conversion for the specified unit is not implemented.")
        };
    }
    public ITime<T> ConvertToBaseUnit()
    {
        return Units switch
        {
            TimeUnits.Second => new Time<T> { Value = Value, Units = TimeUnits.Second },
            TimeUnits.Minute => new Time<T> { Value = Value * T.CreateChecked(60), Units = TimeUnits.Second },
            TimeUnits.Hour => new Time<T> { Value = Value * T.CreateChecked(3600), Units = TimeUnits.Second },
            TimeUnits.Day => new Time<T> { Value = Value * T.CreateChecked(86400), Units = TimeUnits.Second },
            TimeUnits.Week => new Time<T> { Value = Value * T.CreateChecked(604800), Units = TimeUnits.Second },
            TimeUnits.Month => new Time<T> { Value = Value * T.CreateChecked(2.628e+6), Units = TimeUnits.Second }, // Approx. 30.44 days
            TimeUnits.Year => new Time<T> { Value = Value * T.CreateChecked(3.154e+7), Units = TimeUnits.Second }, // Approx. 365.25 days
            _ => throw new NotImplementedException("Conversion for the specified unit is not implemented.")
        };
    }
    #endregion

    #region Public properties
    public override TimeUnits BaseUnit { get; set; } = TimeUnits.Second;
    public override string Description { get; set; } = "Unit of time in the metric system.";
    public override DimensionType Dimension { get; set; } = DimensionType.Time; // Dimension type for time
    public override string Name { get; set; } = "Time";
    public override string Symbol { get; set; } = "s"; // Symbol for seconds
    public override TimeUnits Units { get; set; } = TimeUnits.Second; // Default unit is Second
    public override T Value { get; set; } = T.Zero; // Default value is zero
    #endregion

}
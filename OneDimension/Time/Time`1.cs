using System;
using System.Linq;
using System.Numerics;

using ScienceOfAllLibrary.OneDimension.Mass;
using ScienceOfAllLibrary.OneDimension.Units;

namespace ScienceOfAllLibrary.OneDimension.Time;
public class Time<T> : BaseUnitType<T, TimeUnits>, ITime<T> where T : INumber<T>, new()
{
    public override T Value { get; set; } = T.Zero; // Default value is zero
    public override TimeUnits Units { get; set; } = TimeUnits.Second; // Default unit is Second
    public override string Name { get; set; } = "Time";
    public override string Symbol { get; set; } = "s"; // Symbol for seconds
    public override string Description { get; set; } = "Unit of time in the metric system.";
    public override TimeUnits BaseUnit { get; set; } = TimeUnits.Second;
    public override DimensionType Dimension { get; set; } = DimensionType.Time; // Dimension type for time

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

    public ITime<T> ConvertFrom(TimeUnits units)
    {
        var baseTime = this.ConvertToBaseUnit(); // Convert to base unit (seconds)
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
        return this.Units switch
        {
            TimeUnits.Second => new Time<T> { Value = this.Value, Units = TimeUnits.Second },
            TimeUnits.Minute => new Time<T> { Value = this.Value * T.CreateChecked(60), Units = TimeUnits.Second },
            TimeUnits.Hour => new Time<T> { Value = this.Value * T.CreateChecked(3600), Units = TimeUnits.Second },
            TimeUnits.Day => new Time<T> { Value = this.Value * T.CreateChecked(86400), Units = TimeUnits.Second },
            TimeUnits.Week => new Time<T> { Value = this.Value * T.CreateChecked(604800), Units = TimeUnits.Second },
            TimeUnits.Month => new Time<T> { Value = this.Value * T.CreateChecked(2.628e+6), Units = TimeUnits.Second }, // Approx. 30.44 days
            TimeUnits.Year => new Time<T> { Value = this.Value * T.CreateChecked(3.154e+7), Units = TimeUnits.Second }, // Approx. 365.25 days
            _ => throw new NotImplementedException("Conversion for the specified unit is not implemented.")
        };
    }

    public ITime<T> ConvertTo(TimeUnits units)
    {
        var baseTime = this.ConvertToBaseUnit(); // Convert to base unit (seconds)
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
}
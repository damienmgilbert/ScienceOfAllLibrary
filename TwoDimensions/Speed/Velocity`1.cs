using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;
using System.Numerics;

namespace ScienceOfAllLibrary.TwoDimensions.Speed;

public class Velocity<T> : BaseUnitType<T, VelocityUnits>, IVelocity<T> where T : INumber<T>, new()
{
    public override T Value { get; set; } = T.Zero; // Default value is zero
    public override VelocityUnits Units { get; set; } = VelocityUnits.MetersPerSecond; // Default unit is MetersPerSecond
    public override string Name { get; set; } = "Velocity";
    public override string Symbol { get; set; } = "m/s"; // Symbol for meters per second
    public override string Description { get; set; } = "Unit of velocity in the metric system.";
    public override VelocityUnits BaseUnit { get; set; } = VelocityUnits.MetersPerSecond;

    public Velocity()
    {
        // Default constructor
    }
    public Velocity(T value)
    {
        Value = value; // Initialize with a value
    }
    public Velocity(T value, VelocityUnits units) : this(value)
    {
        Units = units;
    }

    public IVelocity<T> ConvertFrom(VelocityUnits units)
    {
        var baseVelocity = this.ConvertToBaseUnit(); // Convert to base unit (meters per second)
        return units switch
        {
            VelocityUnits.MetersPerSecond => new Velocity<T> { Value = baseVelocity.Value, Units = VelocityUnits.MetersPerSecond },
            VelocityUnits.KilometersPerHour => new Velocity<T> { Value = baseVelocity.Value * T.CreateChecked(3.6), Units = VelocityUnits.KilometersPerHour },
            VelocityUnits.MilesPerHour => new Velocity<T> { Value = baseVelocity.Value * T.CreateChecked(2.237), Units = VelocityUnits.MilesPerHour },
            VelocityUnits.FeetPerSecond => new Velocity<T> { Value = baseVelocity.Value * T.CreateChecked(3.281), Units = VelocityUnits.FeetPerSecond },
            VelocityUnits.Knots => new Velocity<T> { Value = baseVelocity.Value * T.CreateChecked(1.944), Units = VelocityUnits.Knots },
            VelocityUnits.CentimetersPerSecond => new Velocity<T> { Value = baseVelocity.Value / T.CreateChecked(100), Units = VelocityUnits.CentimetersPerSecond },
            VelocityUnits.MillimetersPerSecond => new Velocity<T> { Value = baseVelocity.Value / T.CreateChecked(1000), Units = VelocityUnits.MillimetersPerSecond },
            VelocityUnits.InchesPerSecond => new Velocity<T> { Value = baseVelocity.Value * T.CreateChecked(39.37), Units = VelocityUnits.InchesPerSecond },
            VelocityUnits.Mach => new Velocity<T> { Value = baseVelocity.Value * T.CreateChecked(343.2), Units = VelocityUnits.Mach }, // Speed of sound at sea level in m/s
            VelocityUnits.SpeedOfLight => new Velocity<T> { Value = baseVelocity.Value * T.CreateChecked(299792458), Units = VelocityUnits.SpeedOfLight }, // Speed of light in m/s
            _ => throw new NotImplementedException("Conversion for the specified unit is not implemented.")
        };
    }

    public IVelocity<T> ConvertToBaseUnit()
    {
        var baseValue = this.ConvertToBaseUnit(); // Convert to base unit (meters per second)
        return this.Units switch
        {
            VelocityUnits.MetersPerSecond => new Velocity<T> { Value = baseValue.Value, Units = VelocityUnits.MetersPerSecond },
            VelocityUnits.KilometersPerHour => new Velocity<T> { Value = baseValue.Value / T.CreateChecked(3.6), Units = VelocityUnits.KilometersPerHour },
            VelocityUnits.MilesPerHour => new Velocity<T> { Value = baseValue.Value / T.CreateChecked(2.237), Units = VelocityUnits.MilesPerHour },
            VelocityUnits.FeetPerSecond => new Velocity<T> { Value = baseValue.Value / T.CreateChecked(3.281), Units = VelocityUnits.FeetPerSecond },
            VelocityUnits.Knots => new Velocity<T> { Value = baseValue.Value / T.CreateChecked(1.944), Units = VelocityUnits.Knots },
            VelocityUnits.CentimetersPerSecond => new Velocity<T> { Value = baseValue.Value * T.CreateChecked(100), Units = VelocityUnits.CentimetersPerSecond },
            VelocityUnits.MillimetersPerSecond => new Velocity<T> { Value = baseValue.Value * T.CreateChecked(1000), Units = VelocityUnits.MillimetersPerSecond },
            VelocityUnits.InchesPerSecond => new Velocity<T> { Value = baseValue.Value / T.CreateChecked(39.37), Units = VelocityUnits.InchesPerSecond },
            VelocityUnits.Mach => new Velocity<T> { Value = baseValue.Value / T.CreateChecked(343.2), Units = VelocityUnits.Mach }, // Speed of sound at sea level in m/s
            VelocityUnits.SpeedOfLight => new Velocity<T> { Value = baseValue.Value / T.CreateChecked(299792458), Units = VelocityUnits.SpeedOfLight }, // Speed of light in m/s
            _ => throw new NotImplementedException("Conversion for the specified unit is not implemented.")
        };
    }

    public IVelocity<T> ConvertTo(VelocityUnits units)
    {
        var baseVelocity = this.ConvertToBaseUnit(); // Convert to base unit (meters per second)
        return units switch
        {
            VelocityUnits.MetersPerSecond => new Velocity<T> { Value = baseVelocity.Value, Units = VelocityUnits.MetersPerSecond },
            VelocityUnits.KilometersPerHour => new Velocity<T> { Value = baseVelocity.Value * T.CreateChecked(3.6), Units = VelocityUnits.KilometersPerHour },
            VelocityUnits.MilesPerHour => new Velocity<T> { Value = baseVelocity.Value * T.CreateChecked(2.237), Units = VelocityUnits.MilesPerHour },
            VelocityUnits.FeetPerSecond => new Velocity<T> { Value = baseVelocity.Value * T.CreateChecked(3.281), Units = VelocityUnits.FeetPerSecond },
            VelocityUnits.Knots => new Velocity<T> { Value = baseVelocity.Value * T.CreateChecked(1.944), Units = VelocityUnits.Knots },
            VelocityUnits.CentimetersPerSecond => new Velocity<T> { Value = baseVelocity.Value / T.CreateChecked(100), Units = VelocityUnits.CentimetersPerSecond },
            VelocityUnits.MillimetersPerSecond => new Velocity<T> { Value = baseVelocity.Value / T.CreateChecked(1000), Units = VelocityUnits.MillimetersPerSecond },
            VelocityUnits.InchesPerSecond => new Velocity<T> { Value = baseVelocity.Value * T.CreateChecked(39.37), Units = VelocityUnits.InchesPerSecond },
            VelocityUnits.Mach => new Velocity<T> { Value = baseVelocity.Value * T.CreateChecked(343.2), Units = VelocityUnits.Mach }, // Speed of sound at sea level in m/s
            VelocityUnits.SpeedOfLight => new Velocity<T> { Value = baseVelocity.Value * T.CreateChecked(299792458), Units = VelocityUnits.SpeedOfLight }, // Speed of light in m/s
            _ => throw new NotImplementedException("Conversion for the specified unit is not implemented.")
        };
    }
}
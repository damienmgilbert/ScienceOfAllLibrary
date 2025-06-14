using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.ComponentModel;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Length;

public class Length<T> : BaseUnitType<T, LengthUnits>, ILength<T>
    where T : INumber<T>, new()
{
    public override T Value { get; set; } = T.Zero; // Default value is zero
    public override LengthUnits Units { get; set; } = LengthUnits.Meter; // Default unit is Meter
    public override string Name { get; set; } = "Length";
    public override string Symbol { get; set; } = "m"; // Symbol for meters
    public override string Description { get; set; } = "Unit of length in the metric system.";
    public override LengthUnits BaseUnit { get; set; } = LengthUnits.Meter; // Base unit for length is Meter
    public override DimensionType Dimension { get;set; } = DimensionType.Length; // Dimension type for length

    public Length()
    {
        // Default constructor
    }

    public Length(T value)
    {
        Value = value; // Initialize with a value
    }

    public Length(T value, LengthUnits units) : this(value)
    {
        Units = units;
    }


    public override string? ToString()
    {
        return this.Units.ToString() + " " + this.Value.ToString() + " " + this.Symbol; // Return a string representation of the length
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
    }

    protected override void OnPropertyChanging(PropertyChangingEventArgs e)
    {
        base.OnPropertyChanging(e);
    }

    public ILength<T> ConvertFrom(LengthUnits units)
    {
        var baseValue = this.ConvertToBaseUnit(); // Ensure the value is in base unit before conversion
        return units switch
        {
            LengthUnits.Meter => new Length<T> { Value =baseValue.Value, Units = LengthUnits.Meter },
            LengthUnits.Kilometer => new Length<T> { Value = baseValue.Value / T.CreateChecked(1000), Units = LengthUnits.Kilometer },
            LengthUnits.Centimeter => new Length<T> { Value = baseValue.Value * T.CreateChecked(100), Units = LengthUnits.Centimeter },
            LengthUnits.Millimeter => new Length<T> { Value = baseValue.Value * T.CreateChecked(1000), Units = LengthUnits.Millimeter },
            LengthUnits.Micrometer => new Length<T> { Value = baseValue.Value * T.CreateChecked(1_000_000), Units = LengthUnits.Micrometer },
            LengthUnits.Nanometer => new Length<T> { Value = baseValue.Value * T.CreateChecked(1_000_000_000), Units = LengthUnits.Nanometer },
            LengthUnits.Mile => new Length<T> { Value = baseValue.Value / T.CreateChecked(1609.34), Units = LengthUnits.Mile },
            LengthUnits.Yard => new Length<T> { Value = baseValue.Value / T.CreateChecked(0.9144), Units = LengthUnits.Yard },
            LengthUnits.Foot => new Length<T> { Value = baseValue.Value / T.CreateChecked(0.3048), Units = LengthUnits.Foot },
            LengthUnits.Inch => new Length<T> { Value = baseValue.Value / T.CreateChecked(0.0254), Units = LengthUnits.Inch },
            _ => throw new NotImplementedException($"Conversion from {units} is not implemented.")
        };
    }

    public ILength<T> ConvertToBaseUnit()
    {
        return this.Units switch
        {
            LengthUnits.Meter => new Length<T> { Value = this.Value, Units = LengthUnits.Meter },
            LengthUnits.Kilometer => new Length<T> { Value = this.Value * T.CreateChecked(1000), Units = LengthUnits.Meter },
            LengthUnits.Centimeter => new Length<T> { Value = this.Value / T.CreateChecked(100), Units = LengthUnits.Meter },
            LengthUnits.Millimeter => new Length<T> { Value = this.Value / T.CreateChecked(1000), Units = LengthUnits.Meter },
            LengthUnits.Micrometer => new Length<T> { Value = this.Value / T.CreateChecked(1_000_000), Units = LengthUnits.Meter },
            LengthUnits.Nanometer => new Length<T> { Value = this.Value / T.CreateChecked(1_000_000_000), Units = LengthUnits.Meter },
            LengthUnits.Mile => new Length<T> { Value = this.Value * T.CreateChecked(1609.34), Units = LengthUnits.Meter },
            LengthUnits.Yard => new Length<T> { Value = this.Value * T.CreateChecked(0.9144), Units = LengthUnits.Meter },
            LengthUnits.Foot => new Length<T> { Value = this.Value * T.CreateChecked(0.3048), Units = LengthUnits.Meter },
            LengthUnits.Inch => new Length<T> { Value = this.Value * T.CreateChecked(0.0254), Units = LengthUnits.Meter },
            _ => throw new NotImplementedException($"Conversion for {this.Units} is not implemented.")
        };
    }

    public ILength<T> ConvertTo(LengthUnits units)
    {
        ILength<T> baseValue = this.ConvertToBaseUnit(); // Ensure the value is in base unit before conversion
        return units switch
        {
            LengthUnits.Meter => new Length<T> { Value = baseValue.Value, Units = LengthUnits.Meter },
            LengthUnits.Kilometer => new Length<T> { Value = baseValue.Value / T.CreateChecked(1000), Units = LengthUnits.Kilometer },
            LengthUnits.Centimeter => new Length<T> { Value = baseValue.Value * T.CreateChecked(100), Units = LengthUnits.Centimeter },
            LengthUnits.Millimeter => new Length<T> { Value = baseValue.Value * T.CreateChecked(1000), Units = LengthUnits.Millimeter },
            LengthUnits.Micrometer => new Length<T> { Value = baseValue.Value * T.CreateChecked(1_000_000), Units = LengthUnits.Micrometer },
            LengthUnits.Nanometer => new Length<T> { Value = baseValue.Value * T.CreateChecked(1_000_000_000), Units = LengthUnits.Nanometer },
            LengthUnits.Mile => new Length<T> { Value = baseValue.Value / T.CreateChecked(1609.34), Units = LengthUnits.Mile },
            LengthUnits.Yard => new Length<T> { Value = baseValue.Value / T.CreateChecked(0.9144), Units = LengthUnits.Yard },
            LengthUnits.Foot => new Length<T> { Value = baseValue.Value / T.CreateChecked(0.3048), Units = LengthUnits.Foot },
            LengthUnits.Inch => new Length<T> { Value = baseValue.Value / T.CreateChecked(0.0254), Units = LengthUnits.Inch },
            _ => throw new NotImplementedException($"Conversion to {units} is not implemented.")
        };
    }
}
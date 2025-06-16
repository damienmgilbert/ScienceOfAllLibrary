//-----------------------------------------------------------------------
// <copyright file="Mass`1.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Mass;
public class Mass<T> : BaseUnitType<T, MassUnits>, IMass<T> where T : INumber<T>, new()
{

    #region Constructors
    public Mass()
    {
        // Default constructor
    }
    public Mass(T value)
    {
        Value = value; // Initialize with a value
    }
    public Mass(T value, MassUnits units) : this(value)
    {
        Value = value;
        Units = units;
    }
    #endregion

    #region Public methods
    public IMass<T> ConvertFrom(MassUnits units)
    {
        var baseValue = ConvertToBaseUnit().Value;
        return units switch
        {
            MassUnits.Grams => new Mass<T> { Value = baseValue, Units = MassUnits.Grams },
            MassUnits.Kilograms => new Mass<T> { Value = baseValue / T.CreateChecked(1000), Units = MassUnits.Kilograms },
            MassUnits.Milligrams => new Mass<T> { Value = baseValue * T.CreateChecked(1000), Units = MassUnits.Milligrams },
            MassUnits.Micrograms => new Mass<T> { Value = baseValue * T.CreateChecked(1_000_000), Units = MassUnits.Micrograms },
            MassUnits.MetricTons => new Mass<T> { Value = baseValue / T.CreateChecked(1_000_000), Units = MassUnits.MetricTons },
            MassUnits.Ounces => new Mass<T> { Value = baseValue / T.CreateChecked(28.3495), Units = MassUnits.Ounces },
            MassUnits.Pounds => new Mass<T> { Value = baseValue / T.CreateChecked(453.592), Units = MassUnits.Pounds },
            MassUnits.Stones => new Mass<T> { Value = baseValue / T.CreateChecked(6350.29), Units = MassUnits.Stones },
            MassUnits.ImperialTons => new Mass<T> { Value = baseValue / T.CreateChecked(1016046.91), Units = MassUnits.ImperialTons },
            MassUnits.USShortTons => new Mass<T> { Value = baseValue / T.CreateChecked(907184.74), Units = MassUnits.USShortTons },
            MassUnits.USLongTons => new Mass<T> { Value = baseValue / T.CreateChecked(1016046.91), Units = MassUnits.USLongTons },
            _ => throw new NotImplementedException("Conversion for the specified unit is not implemented.")
        };
    }
    public IMass<T> ConvertTo(MassUnits units)
    {
        var baseValue = ConvertToBaseUnit().Value;
        return units switch
        {
            MassUnits.Grams => new Mass<T> { Value = baseValue, Units = MassUnits.Grams },
            MassUnits.Kilograms => new Mass<T> { Value = baseValue / T.CreateChecked(1000), Units = MassUnits.Kilograms },
            MassUnits.Milligrams => new Mass<T> { Value = baseValue * T.CreateChecked(1000), Units = MassUnits.Milligrams },
            MassUnits.Micrograms => new Mass<T> { Value = baseValue * T.CreateChecked(1_000_000), Units = MassUnits.Micrograms },
            MassUnits.MetricTons => new Mass<T> { Value = baseValue / T.CreateChecked(1_000_000), Units = MassUnits.MetricTons },
            MassUnits.Ounces => new Mass<T> { Value = baseValue / T.CreateChecked(28.3495), Units = MassUnits.Ounces },
            MassUnits.Pounds => new Mass<T> { Value = baseValue / T.CreateChecked(453.592), Units = MassUnits.Pounds },
            MassUnits.Stones => new Mass<T> { Value = baseValue / T.CreateChecked(6350.29), Units = MassUnits.Stones },
            MassUnits.ImperialTons => new Mass<T> { Value = baseValue / T.CreateChecked(1016046.91), Units = MassUnits.ImperialTons },
            MassUnits.USShortTons => new Mass<T> { Value = baseValue / T.CreateChecked(907184.74), Units = MassUnits.USShortTons },
            MassUnits.USLongTons => new Mass<T> { Value = baseValue / T.CreateChecked(1016046.91), Units = MassUnits.USLongTons },
            _ => throw new NotImplementedException($"Conversion to {units} is not implemented.")
        };
    }
    public IMass<T> ConvertToBaseUnit()
    {
        return Units switch
        {
            MassUnits.Grams => new Mass<T> { Value = Value, Units = MassUnits.Grams },
            MassUnits.Kilograms => new Mass<T> { Value = Value * T.CreateChecked(1000), Units = MassUnits.Grams },
            MassUnits.Milligrams => new Mass<T> { Value = Value / T.CreateChecked(1000), Units = MassUnits.Grams },
            MassUnits.Micrograms => new Mass<T> { Value = Value / T.CreateChecked(1_000_000), Units = MassUnits.Grams },
            MassUnits.MetricTons => new Mass<T> { Value = Value * T.CreateChecked(1_000_000), Units = MassUnits.Grams },
            MassUnits.Ounces => new Mass<T> { Value = Value * T.CreateChecked(28.3495), Units = MassUnits.Grams },
            MassUnits.Pounds => new Mass<T> { Value = Value * T.CreateChecked(453.592), Units = MassUnits.Grams },
            MassUnits.Stones => new Mass<T> { Value = Value * T.CreateChecked(6350.29), Units = MassUnits.Grams },
            MassUnits.ImperialTons => new Mass<T> { Value = Value * T.CreateChecked(1016046.91), Units = MassUnits.Grams },
            MassUnits.USShortTons => new Mass<T> { Value = Value * T.CreateChecked(907184.74), Units = MassUnits.Grams },
            MassUnits.USLongTons => new Mass<T> { Value = Value * T.CreateChecked(1016046.91), Units = MassUnits.Grams },
            _ => throw new NotImplementedException("Conversion for the specified unit is not implemented.")
        };
    }
    #endregion

    #region Public properties
    public override MassUnits BaseUnit { get; set; } = MassUnits.Grams; // Base unit for mass is Grams
    public override string Description { get; set; } = "Unit of mass in the metric system.";
    public override DimensionType Dimension { get; set; } = DimensionType.Mass; // Dimension type for mass  
    public override string Name { get; set; } = "Mass";
    public override string Symbol { get; set; } = "kg"; // Symbol for kilograms
    public override MassUnits Units { get; set; } = MassUnits.Grams; // Default unit is Grams
    public override T Value { get; set; } = T.Zero; // Default value is zero
    #endregion

}

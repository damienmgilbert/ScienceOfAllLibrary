//-----------------------------------------------------------------------
// <copyright file="Area`1.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.TwoDimensions.Surface;
public class Area<T> : BaseUnitType<T, AreaUnits>, IArea<T> where T : INumber<T>, new()
{

    #region Constructors
    public Area()
    {
    }
    public Area(T value)
    {
        Value = value; // Initialize with a value
    }
    public Area(T value, AreaUnits units) : this(value)
    {
        Units = units;
    }
    #endregion

    #region Public methods
    public IArea<T> ConvertFrom(AreaUnits units)
    {
        var baseArea = ConvertToBaseUnit(); // Ensure the value is in base unit before conversion
        return units switch
        {
            AreaUnits.SquareMeter => new Area<T> { Value = baseArea.Value, Units = AreaUnits.SquareMeter },
            AreaUnits.SquareKilometer => new Area<T> { Value = baseArea.Value / T.CreateChecked(1_000_000), Units = AreaUnits.SquareKilometer },
            AreaUnits.SquareCentimeter => new Area<T> { Value = baseArea.Value * T.CreateChecked(10_000), Units = AreaUnits.SquareCentimeter },
            AreaUnits.SquareMillimeter => new Area<T> { Value = baseArea.Value * T.CreateChecked(1_000_000), Units = AreaUnits.SquareMillimeter },
            AreaUnits.SquareInch => new Area<T> { Value = baseArea.Value / T.CreateChecked(0.00064516), Units = AreaUnits.SquareInch },
            AreaUnits.SquareFoot => new Area<T> { Value = baseArea.Value / T.CreateChecked(0.092903), Units = AreaUnits.SquareFoot },
            AreaUnits.SquareYard => new Area<T> { Value = baseArea.Value / T.CreateChecked(0.836127), Units = AreaUnits.SquareYard },
            AreaUnits.Hectare => new Area<T> { Value = baseArea.Value / T.CreateChecked(10_000), Units = AreaUnits.Hectare },
            AreaUnits.Acre => new Area<T> { Value = baseArea.Value / T.CreateChecked(4046.86), Units = AreaUnits.Acre },
            AreaUnits.SquareMile => new Area<T> { Value = baseArea.Value / T.CreateChecked(2_589_988), Units = AreaUnits.SquareMile },
            AreaUnits.SquareDecimeter => new Area<T> { Value = baseArea.Value * T.CreateChecked(100), Units = AreaUnits.SquareDecimeter },
            AreaUnits.SquareMicrometer => new Area<T> { Value = baseArea.Value * T.CreateChecked(1_000_000_000), Units = AreaUnits.SquareMicrometer },
            AreaUnits.SquareNanometer => new Area<T> { Value = baseArea.Value * T.CreateChecked(1_000_000_000_000_000), Units = AreaUnits.SquareNanometer },
            AreaUnits.SquarePicometer => new Area<T> { Value = baseArea.Value * T.CreateChecked(1_000_000_000_000_000_000), Units = AreaUnits.SquarePicometer },
            _ => throw new NotImplementedException("Conversion for the specified unit is not implemented.")
        };
    }
    public IArea<T> ConvertTo(AreaUnits units)
    {
        throw new NotImplementedException();
    }
    public IArea<T> ConvertToBaseUnit()
    {
        return Units switch
        {
            AreaUnits.SquareMeter => new Area<T> { Value = Value, Units = AreaUnits.SquareMeter },
            AreaUnits.SquareKilometer => new Area<T> { Value = Value * T.CreateChecked(1_000_000), Units = AreaUnits.SquareMeter },
            AreaUnits.SquareCentimeter => new Area<T> { Value = Value / T.CreateChecked(10_000), Units = AreaUnits.SquareMeter },
            AreaUnits.SquareMillimeter => new Area<T> { Value = Value / T.CreateChecked(1_000_000), Units = AreaUnits.SquareMeter },
            AreaUnits.SquareInch => new Area<T> { Value = Value * T.CreateChecked(0.00064516), Units = AreaUnits.SquareMeter },
            AreaUnits.SquareFoot => new Area<T> { Value = Value * T.CreateChecked(0.092903), Units = AreaUnits.SquareMeter },
            AreaUnits.SquareYard => new Area<T> { Value = Value * T.CreateChecked(0.836127), Units = AreaUnits.SquareMeter },
            AreaUnits.Hectare => new Area<T> { Value = Value * T.CreateChecked(10_000), Units = AreaUnits.SquareMeter },
            AreaUnits.Acre => new Area<T> { Value = Value * T.CreateChecked(4046.86), Units = AreaUnits.SquareMeter },
            AreaUnits.SquareMile => new Area<T> { Value = Value * T.CreateChecked(2_589_988), Units = AreaUnits.SquareMeter },
            AreaUnits.SquareDecimeter => new Area<T> { Value = Value / T.CreateChecked(100), Units = AreaUnits.SquareMeter },
            AreaUnits.SquareMicrometer => new Area<T> { Value = Value / T.CreateChecked(1_000_000_000), Units = AreaUnits.SquareMeter },
            AreaUnits.SquareNanometer => new Area<T> { Value = Value / T.CreateChecked(1_000_000_000_000_000), Units = AreaUnits.SquareMeter },
            AreaUnits.SquarePicometer => new Area<T> { Value = Value / T.CreateChecked(1_000_000_000_000_000_000), Units = AreaUnits.SquareMeter },
            _ => throw new NotImplementedException("Conversion for the specified unit is not implemented.")
        };
    }
    #endregion

    #region Public properties
    public override AreaUnits BaseUnit { get; set; } = AreaUnits.SquareMeter; // Base unit for area is Square Meter
    public override string Description { get; set; } = "Unit of area in the metric system.";
    public override DimensionType Dimension { get; set; }
    public override string Name { get; set; } = "Area";
    public override string Symbol { get; set; } = "m²"; // Symbol for square meters
    public override AreaUnits Units { get; set; } = AreaUnits.SquareMeter; // Default unit is Square Meter
    public override T Value { get; set; } = T.Zero; // Default value is zero
    #endregion

}
//-----------------------------------------------------------------------
// <copyright file="Substance`1.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Substance;
public class Substance<T> : BaseUnitType<T, SubstanceUnits>, ISubstance<T> where T : INumber<T>, new()
{

    #region Constructors
    public Substance(T value)
    {
        Value = value; // Initialize with a value
    }
    public Substance(T value, SubstanceUnits units) : this(value)
    {
        Units = units;
    }
    #endregion

    #region Public methods
    public ISubstance<T> ConvertFrom(SubstanceUnits units)
    {
        var baseValue = ConvertToBaseUnits().Value;
        return units switch
        {
            SubstanceUnits.Mole => new Substance<T>(baseValue, SubstanceUnits.Mole),
            SubstanceUnits.Millimole => new Substance<T>(baseValue * T.CreateChecked(1000), SubstanceUnits.Millimole),
            SubstanceUnits.Micromole => new Substance<T>(baseValue * T.CreateChecked(1_000_000), SubstanceUnits.Micromole),
            SubstanceUnits.Kilomole => new Substance<T>(baseValue / T.CreateChecked(1000), SubstanceUnits.Kilomole),
            SubstanceUnits.Megamole => new Substance<T>(baseValue / T.CreateChecked(1_000_000), SubstanceUnits.Megamole),
            _ => throw new NotSupportedException($"Conversion from base unit to {units} is not supported.")
        };
    }
    public ISubstance<T> ConvertTo(SubstanceUnits units)
    {
        var baseValue = ConvertToBaseUnits().Value;
        return units switch
        {
            SubstanceUnits.Mole => new Substance<T>(baseValue, SubstanceUnits.Mole),
            SubstanceUnits.Millimole => new Substance<T>(baseValue * T.CreateChecked(1000), SubstanceUnits.Millimole),
            SubstanceUnits.Micromole => new Substance<T>(baseValue * T.CreateChecked(1_000_000), SubstanceUnits.Micromole),
            SubstanceUnits.Kilomole => new Substance<T>(baseValue / T.CreateChecked(1000), SubstanceUnits.Kilomole),
            SubstanceUnits.Megamole => new Substance<T>(baseValue / T.CreateChecked(1_000_000), SubstanceUnits.Megamole),
            _ => throw new NotSupportedException($"Conversion to {units} is not supported.")
        };
    }
    public ISubstance<T> ConvertToBaseUnits()
    {
        return Units switch
        {
            SubstanceUnits.Mole => this,
            SubstanceUnits.Millimole => new Substance<T>(Value / T.CreateChecked(1000), SubstanceUnits.Mole),
            SubstanceUnits.Micromole => new Substance<T>(Value / T.CreateChecked(1_000_000), SubstanceUnits.Mole),
            SubstanceUnits.Kilomole => new Substance<T>(Value * T.CreateChecked(1000), SubstanceUnits.Mole),
            SubstanceUnits.Megamole => new Substance<T>(Value * T.CreateChecked(1_000_000), SubstanceUnits.Mole),
            _ => throw new NotSupportedException($"Conversion from {Units} to base unit is not supported.")
        };
    }
    #endregion

    #region Public properties
    public override SubstanceUnits BaseUnit { get; set; } = SubstanceUnits.Mole; // Base unit for substance is Mole
    public override string Description { get; set; } = "Unit of amount of substance in the International System of Units (SI).";
    public override DimensionType Dimension { get; set; } = DimensionType.AmountOfSubstance; // Dimension type for substance    
    public override string Name { get; set; } = "Substance";
    public override string Symbol { get; set; } = "mol"; // Symbol for moles
    public override SubstanceUnits Units { get; set; } = SubstanceUnits.Mole; // Default unit is Mole
    public override T Value { get; set; } = T.Zero; // Default value is zero
    #endregion

}
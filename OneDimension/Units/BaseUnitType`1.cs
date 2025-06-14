using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;

using CommunityToolkit.Mvvm.ComponentModel;

namespace ScienceOfAllLibrary.OneDimension.Units;

public abstract class BaseUnitType<T, E> : ObservableObject, IBaseUnitType<T, E> where T : INumber<T>, new()
where E : Enum
{
    public BaseUnitType()
    {
        // Default constructor
    }

    protected BaseUnitType(T value, E units, string name, string symbol, string description, E baseUnit, DimensionType dimension)
    {
        Value = value;
        Units = units;
        Name = name;
        Symbol = symbol;
        Description = description;
        BaseUnit = baseUnit;
        Dimension = dimension;
    }

    [Display(Name = "Value")]
    public abstract T Value { get; set; } // Value of the unit type, e.g., 5 meters, 10 kilograms, etc.

    [Display(Name = "SI Units")]
    public abstract E Units { get; set; }

    [Display(Name = "Quality")]
    [MinLength(1)]
    [MaxLength(100)]
    public abstract string Name { get; set; } // Name of the unit type, e.g., "Length", "Mass", etc.

    [Display(Name = "Symbol")]
    [MinLength(1)]
    [MaxLength(100)]
    public abstract string Symbol { get; set; } // Symbol for the unit type, e.g., "m" for meters, "kg" for kilograms, etc.

    [Display(Name = "Description")]
    [MinLength(1)]
    [MaxLength(100)]
    public abstract string Description { get; set; } // Description of the unit type, e.g., "Unit of length in the metric system", "Unit of mass in the metric system", etc.
    
    [Display(Name = "Base Unit")]
    public abstract E BaseUnit { get; set; } // Base unit for the unit type, e.g., "Meter" for length, "Kilogram" for mass, etc.

    [Display(Name = "Dimension")]
    public abstract DimensionType Dimension { get; set; }

    public static BaseUnitType<T, E> operator +(BaseUnitType<T, E> left, BaseUnitType<T,E> right)
    {
        var leftUnits = left.Units.GetType().GetEnumName(left.Units);
        int leftUnitValue = (int)Enum.Parse(left.Units.GetType(), leftUnits);

        var rightUnits = right.Units.GetType().GetEnumName(right.Units);
        int rightUnitValue = (int)Enum.Parse(right.Units.GetType(), rightUnits);
        if (leftUnits != rightUnits)
        {
            throw new InvalidOperationException("Cannot add units of different types.");
        }

        left.Value += right.Value; // Add the values of the two unit types
        return left; // Return the modified left unit type
    }

    public static BaseUnitType<T, E> operator -(BaseUnitType<T, E> left, BaseUnitType<T,E> right)
    {
        var leftUnits = left.Units.GetType().GetEnumName(left.Units);
        var rightUnits = right.Units.GetType().GetEnumName(right.Units);
        if (leftUnits != rightUnits)
        {
            throw new InvalidOperationException("Cannot subtract units of different types.");
        }
        left.Value -= right.Value; // Subtract the values of the two unit types
        return left; // Return the modified left unit type
    }
}

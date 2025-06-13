using System;
using System.Linq;

using CommunityToolkit.Mvvm.ComponentModel;

namespace ScienceOfAllLibrary.OneDimension.Units;

public abstract class BaseUnitType<E> : ObservableObject, IBaseUnitType<E>
where E : Enum
{
    public BaseUnitType()
    {
        // Default constructor
    }
    public abstract E Units { get; set; }
    public abstract string Name { get; set; } // Name of the unit type, e.g., "Length", "Mass", etc.
    public abstract string Symbol { get; set; } // Symbol for the unit type, e.g., "m" for meters, "kg" for kilograms, etc.
    public abstract string Description { get; set; } // Description of the unit type, e.g., "Unit of length in the metric system", "Unit of mass in the metric system", etc.
    public abstract E BaseUnit { get; set; } // Base unit for the unit type, e.g., "Meter" for length, "Kilogram" for mass, etc.

}

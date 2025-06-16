using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Units.BaseUnits.Masses;

public enum MassUnit
{
    // SI Base Unit
    Kilogram,

    // Non-SI Metric Units
    Tonne,         // Also known as metric ton
    AtomicMassUnit, // Used in atomic and molecular physics

    // Imperial/U.S. Units
    Pound,
    Ounce,
    Stone,
    Quarter,
    Hundredweight,
    Ton,          // Short ton (U.S.) or long ton (British)

    // Specialized Units
    Carat,         // Used in gem measurement
    Slug,          // Used in engineering dynamics
    SolarMass,     // Mass of the Sun, used in astrophysics

    // Physics/Natural Units
    PlanckMass     // Fundamental theoretical physics mass unit
}

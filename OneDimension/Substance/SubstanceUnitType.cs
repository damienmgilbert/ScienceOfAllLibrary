using ScienceOfAllLibrary.OneDimension.Units;

using System;

using System.Linq;

namespace ScienceOfAllLibrary.OneDimension.Substance;

public class SubstanceUnitType : BaseUnitType<SubstanceUnits>
{
    public override SubstanceUnits Units { get; set; } = SubstanceUnits.Mole; // Default unit is Mole
    public override string Name { get; set; } = "Substance";
    public override string Symbol { get; set; } = "mol"; // Symbol for moles
    public override string Description { get; set; } = "Unit of amount of substance in the International System of Units (SI).";
    public override SubstanceUnits BaseUnit { get; set; } = SubstanceUnits.Mole; // Base unit for substance is Mole
}

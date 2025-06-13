using ScienceOfAllLibrary.OneDimension.Units;

using System;

using System.Linq;

namespace ScienceOfAllLibrary.OneDimension.ElectricCurrent;

public class ElectricCurrentUnitType : BaseUnitType<ElectricCurrentUnits>, IElectricCurrentUnitType
{
    public override ElectricCurrentUnits Units { get; set; } = ElectricCurrentUnits.Ampere; // Default unit is Ampere
    public override string Name { get; set; } = "Electric Current";
    public override string Symbol { get; set; } = "A"; // Symbol for amperes
    public override string Description { get; set; } = "Unit of electric current in the International System of Units (SI).";
    public override ElectricCurrentUnits BaseUnit { get; set; } = ElectricCurrentUnits.Ampere;
}

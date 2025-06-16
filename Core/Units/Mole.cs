using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Units;

public class Mole : PhysicalUnitBase
{
    public override string Name => "Mole";
    public override string Symbol => "mol";
    public override string Dimension => "N";
    public override string QuantityName => "Amount of Substance";
    public override string Definition => "The amount of substance of 6.02214076×10²³ elementary entities, defined by the Avogadro constant.";
}

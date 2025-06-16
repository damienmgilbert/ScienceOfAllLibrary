using System;
using System.Linq;
using System.Numerics;

using ScienceOfAllLibrary.Core.Prefixes;

namespace ScienceOfAllLibrary.Core.Units.BaseUnits.AmountOfSubstances;

public class Mole<T> : PhysicalUnitBase<T, AmountOfSubstanceUnit> where T : INumber<T>, new()
{
    public Mole(T value, AmountOfSubstanceUnit units) : base(value, units)
    {
    }

    public override T Value { get; set; }
    public override string Name => "Mole";
    public override string Symbol => "mol";
    public override string Dimension => "N";
    public override string QuantityName => "Amount of Substance";
    public override string Definition => "The amount of substance of 6.02214076×10²³ elementary entities, defined by the Avogadro constant.";

    public override AmountOfSubstanceUnit Units { get; set; } = AmountOfSubstanceUnit.Mole;
    public override IPrefix Prefix { get; set; } = new NoPrefix();
}

using System;
using System.Linq;
using System.Numerics;

using ScienceOfAllLibrary.Core.Prefixes;
namespace ScienceOfAllLibrary.Core.Units;

public class PhysicalQuantity<TUnit, TValue> where TUnit : PhysicalUnitBase where TValue : INumber<TValue>
{
    public TUnit Unit { get; }
    public TValue Value { get; }

    public ISIPrefixBase Prefix { get; }

    private ISIPrefixBase CalculatePrefix()
    {
        ISIPrefixBase prefix = this.Value switch
        {
            decimal d when d >= 1e24m => new YottaPrefix(),
            decimal d when d >= 1e21m => new ZettaPrefix(),
            decimal d when d >= 1e18m => new ExaPrefix(),
            decimal d when d >= 1e15m => new PetaPrefix(),
            decimal d when d >= 1e12m => new TeraPrefix(),
            decimal d when d >= 1e9m => new GigaPrefix(),
            decimal d when d >= 1e6m => new MegaPrefix(),
            decimal d when d >= 1e3m => new KiloPrefix(),
            decimal d when d >= 1e-3m => new MilliPrefix(),
            decimal d when d >= 1e-6m => new MicroPrefix(),
            decimal d when d >= 1e-9m => new NanoPrefix(),
            decimal d when d >= 1e-12m => new PicoPrefix(),
            decimal d when d >= 1e-15m => new FemtoPrefix(),
            decimal d when d >= 1e-18m => new AttoPrefix(),
            decimal d when d >= 1e-21m => new ZeptoPrefix(),
            decimal d when d >= 1e-24m => new YoctoPrefix(),
            decimal d when d == 0 => new NonePrefix(),
            _ => throw new ArgumentOutOfRangeException(nameof(Value), "Value is out of range for SI prefixes.")
        };
        return prefix;
    }

    public PhysicalQuantity(TUnit unit, TValue value)
    {
        Unit = unit;
        Value = value;
    }

    public override string ToString()
    {
        return $"{Value} {Unit.Symbol}";
    }
}

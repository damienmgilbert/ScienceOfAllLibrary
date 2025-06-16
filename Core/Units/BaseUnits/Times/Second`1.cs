using System;
using System.Linq;
using System.Numerics;

using ScienceOfAllLibrary.Core.Prefixes;

namespace ScienceOfAllLibrary.Core.Units.BaseUnits.Times;

// Base physical units
public class Second<TValue> : PhysicalUnitBase<TValue, TimeUnit>, ITimeUnits<TValue> 
    where TValue : INumber<TValue>, new()
{
    public Second(TValue value, TimeUnit units) : base(value, units)
    {

    }

    public override TValue Value { get; set; } = TValue.Zero;

    public override IPrefix Prefix { get; set; } = new NoPrefix();

    public override string Name => "Second";

    public override string Symbol => "s";

    public override string Dimension => "T";

    public override string QuantityName => "Time";

    public override string Definition => "The duration of 9192631770 periods of the radiation corresponding to the transition between the two hyperfine levels of the ground state of the caesium-133 atom.";

    public override TimeUnit Units { get; set; } = TimeUnit.Second;
}

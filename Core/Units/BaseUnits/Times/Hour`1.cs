
using ScienceOfAllLibrary.Core.Prefixes;

using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.Core.Units.BaseUnits.Times;
public class Hour<TValue> : PhysicalUnitBase<TValue, TimeUnit>, ITimeUnits<TValue> where TValue : INumber<TValue>, new()
{
    public Hour(TValue value, TimeUnit units) : base(value, units)
    {

    }

    public override string Name => "Hours";

    public override string Symbol => "hr";

    public override string Dimension => "T";

    public override string QuantityName => "Time";

    public override string Definition => "Hours ";

    public override TimeUnit Units { get; set; } = TimeUnit.Hour;
    public override IPrefix Prefix { get; set; } = new NoPrefix();
    public override TValue Value { get; set; }
}

using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Units;

public abstract class PhysicalUnitBase
{
    public abstract string Name { get; }
    public abstract string Symbol { get; }
    public abstract string Dimension { get; }
    public abstract string QuantityName { get; }
    public abstract string Definition { get; }

    public override string ToString()
    {
        return $"{Name} ({Symbol}) - Dimension: {Dimension}, Quantity: {QuantityName}, Definition: {Definition}";
    }
}

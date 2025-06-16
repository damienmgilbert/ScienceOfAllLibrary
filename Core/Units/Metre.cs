using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Units;

public class Metre : PhysicalUnitBase
{
    public override string Name => "Metre";
    public override string Symbol => "m";
    public override string Dimension => "L";
    public override string QuantityName => "Length";
    public override string Definition => "The distance travelled by light in vacuum in 1/299792458 second.";
}

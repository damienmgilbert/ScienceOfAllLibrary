using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Units;


// Base physical units
public class Second : PhysicalUnitBase
{
    public override string Name => "Second";
    public override string Symbol => "s";
    public override string Dimension => "T";
    public override string QuantityName => "Time";
    public override string Definition => "The duration of 9192631770 periods of the radiation corresponding to the transition between the two hyperfine levels of the ground state of the caesium-133 atom.";
}

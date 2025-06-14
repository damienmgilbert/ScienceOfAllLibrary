using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Substance;
public interface ISubstance<T> : IBaseUnitType<T, SubstanceUnits> where T : INumber<T>
{
    public ISubstance<T> ConvertToBaseUnits();
    public ISubstance<T> ConvertFrom(SubstanceUnits units);
    public ISubstance<T> ConvertTo(SubstanceUnits units);

}

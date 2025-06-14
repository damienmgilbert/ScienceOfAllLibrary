using ScienceOfAllLibrary.OneDimension.Units;

using System;

using System.Linq;
using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Mass;

public interface IMassUnitType<T> : IBaseUnitType<T, MassUnits> where T : INumber<T>
{
    // Define any additional methods or properties specific to mass units if needed
}



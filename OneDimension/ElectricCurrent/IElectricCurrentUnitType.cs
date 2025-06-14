using ScienceOfAllLibrary.OneDimension.Units;

using System;

using System.Linq;
using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.ElectricCurrent;

public interface IElectricCurrentUnitType<T> : IBaseUnitType<T, ElectricCurrentUnits> where T : INumber<T>
{
    // This interface can be extended with methods specific to electric current units if needed
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using ScienceOfAllLibrary.OneDimension.Units;

namespace ScienceOfAllLibrary.OneDimension.Temperature;
public interface ITemperatureUnitType<T> : IBaseUnitType<T, TemperatureUnits> where T : INumber<T>
{
}

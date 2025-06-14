using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using ScienceOfAllLibrary.OneDimension.Units;

namespace ScienceOfAllLibrary.OneDimension.Time;
public interface ITimeUnitType<T> : IBaseUnitType<T, TimeUnits> where T : INumber<T>
{
}

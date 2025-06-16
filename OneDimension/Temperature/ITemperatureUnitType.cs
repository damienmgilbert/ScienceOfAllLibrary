//-----------------------------------------------------------------------
// <copyright file="ITemperatureUnitType.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using System.Threading.Tasks;

namespace ScienceOfAllLibrary.OneDimension.Temperature;
public interface ITemperatureUnitType<T> : IBaseUnitType<T, TemperatureUnits> where T : INumber<T>
{
}

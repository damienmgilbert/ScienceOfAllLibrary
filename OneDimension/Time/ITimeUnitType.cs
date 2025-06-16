//-----------------------------------------------------------------------
// <copyright file="ITimeUnitType.cs" company="">
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

namespace ScienceOfAllLibrary.OneDimension.Time;
public interface ITimeUnitType<T> : IBaseUnitType<T, TimeUnits> where T : INumber<T>
{
}

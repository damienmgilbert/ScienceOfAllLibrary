//-----------------------------------------------------------------------
// <copyright file="IAreaUnitType`1.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using ScienceOfAllLibrary.OneDimension.Units;

using System;

using System.Linq;
using System.Numerics;

namespace ScienceOfAllLibrary.TwoDimensions.Surface;
public interface IAreaUnitType<T> : IBaseUnitType<T, AreaUnits> where T : INumber<T>, new()
{
    // This interface can be extended with additional properties or methods specific to area units
}

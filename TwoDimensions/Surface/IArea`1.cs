//-----------------------------------------------------------------------
// <copyright file="IArea`1.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;

using System.Linq;
using System.Numerics;

namespace ScienceOfAllLibrary.TwoDimensions.Surface;
public interface IArea<T> : IAreaUnitType<T> where T : INumber<T>, new()
{

    #region Public methods
    /// <summary>
    /// Converts the current area value from the specified units to the base unit (Square Meter).
    /// </summary>
    /// <param name="units"></param>
    /// <returns></returns>
    public IArea<T> ConvertFrom(AreaUnits units);
    /// <summary>
    /// Converts the current area value to the specified units.
    /// </summary>
    /// <param name="units"></param>
    /// <returns></returns>
    public IArea<T> ConvertTo(AreaUnits units); // Method to change the units of the physical unit
    /// <summary>
    /// Converts the current area value to the base unit (Square Meter).
    /// </summary>
    /// <returns></returns>
    public IArea<T> ConvertToBaseUnit(); // Method to convert the value to the base unit (Square Meter)
    #endregion

}

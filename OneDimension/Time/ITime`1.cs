//-----------------------------------------------------------------------
// <copyright file="ITime`1.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;
using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Time;
public interface ITime<T> : ITimeUnitType<T> where T : INumber<T>
{

    #region Public methods
    public ITime<T> ConvertFrom(TimeUnits units);
    public ITime<T> ConvertTo(TimeUnits units); // Method to change the units of the physical unit
    public ITime<T> ConvertToBaseUnit(); // Method to convert the value to the base unit
    #endregion

}

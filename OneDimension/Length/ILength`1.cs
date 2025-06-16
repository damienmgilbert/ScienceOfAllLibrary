//-----------------------------------------------------------------------
// <copyright file="ILength`1.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Length;
public interface ILength<T> : ILengthUnitType<T> where T : INumber<T>, new()
{

    #region Public methods
    public ILength<T> ConvertFrom(LengthUnits units);
    public ILength<T> ConvertTo(LengthUnits units); // Method to change the units of the physical unit
    public ILength<T> ConvertToBaseUnit(); // Method to convert the value to the base unit
    #endregion

}

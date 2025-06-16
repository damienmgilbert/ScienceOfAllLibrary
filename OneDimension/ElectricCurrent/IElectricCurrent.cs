//-----------------------------------------------------------------------
// <copyright file="IElectricCurrent.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.ElectricCurrent;
public interface IElectricCurrent<T> : IElectricCurrentUnitType<T> where T : INumber<T>, new()
{

    #region Public methods
    public IElectricCurrent<T> ConvertFrom(ElectricCurrentUnits units);
    public IElectricCurrent<T> ConvertTo(ElectricCurrentUnits units); // Method to change the units of the physical unit
    public IElectricCurrent<T> ConvertToBaseUnit(); // Method to convert the value to the base unit
    #endregion

}
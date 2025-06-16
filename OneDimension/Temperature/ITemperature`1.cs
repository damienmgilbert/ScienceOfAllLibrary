//-----------------------------------------------------------------------
// <copyright file="ITemperature`1.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Temperature;
public interface ITemperature<T> : ITemperatureUnitType<T> where T : INumber<T>, new()
{

    #region Public methods
    ITemperature<T> ConvertFromUnits(TemperatureUnits units); // Method to convert from a specific unit to the base unit
    ITemperature<T> ConvertToBaseUnit(); // Method to convert temperature to base unit (Celsius)
    // Interface for temperature unit types, inheriting from base unit type
    // This can be extended with additional methods or properties specific to temperature if needed
    ITemperature<T> ConvertToUnits(TemperatureUnits units); // Method to convert temperature to different units
    #endregion

}

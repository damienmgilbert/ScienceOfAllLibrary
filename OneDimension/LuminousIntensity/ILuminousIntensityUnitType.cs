//-----------------------------------------------------------------------
// <copyright file="ILuminousIntensityUnitType.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using ScienceOfAllLibrary.OneDimension.Units;

using System;

using System.Linq;
using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.LuminousIntensity;
public interface ILuminousIntensityUnitType<T> : IBaseUnitType<T, LuminousIntensityUnits> where T : INumber<T>
{
    // This interface can be extended with methods specific to luminous intensity units if needed
}

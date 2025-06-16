//-----------------------------------------------------------------------
// <copyright file="ISubstanceUnitType.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using ScienceOfAllLibrary.OneDimension.Units;

using System;

using System.Linq;
using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Substance;
public interface ISubstanceUnitType<T> : IBaseUnitType<T, SubstanceUnits> where T : INumber<T>
{
    // Interface for Substance unit types, extending the base unit type interface
}

//-----------------------------------------------------------------------
// <copyright file="FundamentalDimension.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ScienceOfAllLibrary.DimensionalAnalyze;
/// <summary>
/// Represents the seven fundamental SI dimensions
/// </summary>
public enum FundamentalDimension
{
    Length = 0,      // [L] - meter
    Mass = 1,        // [M] - kilogram  
    Time = 2,        // [T] - second
    Current = 3,     // [I] - ampere
    Temperature = 4, // [Θ] - kelvin
    AmountOfSubstance = 5,      // [N] - mole
    Luminosity = 6   // [J] - candela
}
public enum TwoDimensionalFormula
{
    LengthSquared = 0, // [L²]
    MassLength = 1,    // [ML]
    MassTime = 2,      // [MT]
    TimeSquared = 3,   // [T²]
    LengthTime = 4,    // [LT]
    MassSquared = 5,   // [M²]
    TimeLength = 6     // [TL]
}

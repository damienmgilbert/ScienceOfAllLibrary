//-----------------------------------------------------------------------
// <copyright file="LuminousIntensityUnits.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ScienceOfAllLibrary.OneDimension.LuminousIntensity;
public enum LuminousIntensityUnits
{
    Candela, // Base unit of luminous intensity in the International System of Units (SI)
    LumenPerSteradian, // Luminous intensity per solid angle
    Nit, // Luminous intensity per unit area (candela per square meter)
    Lumen
}

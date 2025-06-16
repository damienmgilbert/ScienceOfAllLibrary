//-----------------------------------------------------------------------
// <copyright file="VelocityUnits.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ScienceOfAllLibrary.TwoDimensions.Speed;
public enum VelocityUnits
{
    MetersPerSecond, // Base unit
    KilometersPerHour, // Common unit for speed in vehicles
    MilesPerHour, // Common unit for speed in the US and UK
    FeetPerSecond, // Common unit in some engineering contexts
    Knots, // Common unit for speed in aviation and maritime contexts
    CentimetersPerSecond, // Less common but used in some scientific contexts
    MillimetersPerSecond, // Used in precision engineering and scientific measurements
    InchesPerSecond, // Used in some engineering contexts, especially in the US
    Mach, // Unit for speed relative to the speed of sound, used in aviation
    SpeedOfLight, // Unit for speed relative to the speed of light, used in theoretical physics
}

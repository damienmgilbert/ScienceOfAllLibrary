//-----------------------------------------------------------------------
// <copyright file="TimeUnits.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceOfAllLibrary.OneDimension.Time;
public enum TimeUnits
{
    Second,        // Base unit of time
    Minute,        // 60 seconds
    Hour,          // 3600 seconds
    Day,           // 86400 seconds
    Week,          // 604800 seconds
    Month,         // Approx. 2.628e+6 seconds (30.44 days)
    Year           // Approx. 3.154e+7 seconds (365.25 days)

}

//-----------------------------------------------------------------------
// <copyright file="IVelocityUnitType`1.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;
using System.Numerics;

namespace ScienceOfAllLibrary.TwoDimensions.Speed;
public interface IVelocityUnitType<T> : IBaseUnitType<T, VelocityUnits> where T : INumber<T>, new()
{
    // This interface can be extended with additional properties or methods specific to velocity units
}

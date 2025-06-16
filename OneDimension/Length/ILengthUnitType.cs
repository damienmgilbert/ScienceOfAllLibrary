//-----------------------------------------------------------------------
// <copyright file="ILengthUnitType.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using ScienceOfAllLibrary.OneDimension.Units;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Length;
public interface ILengthUnitType<T> : IBaseUnitType<T, LengthUnits> where T : INumber<T>
{
}
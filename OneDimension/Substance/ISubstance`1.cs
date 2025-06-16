//-----------------------------------------------------------------------
// <copyright file="ISubstance`1.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using ScienceOfAllLibrary.OneDimension.Units;

using System;
using System.Linq;

using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.Substance;
public interface ISubstance<T> : IBaseUnitType<T, SubstanceUnits> where T : INumber<T>
{

    #region Public methods
    public ISubstance<T> ConvertFrom(SubstanceUnits units);
    public ISubstance<T> ConvertTo(SubstanceUnits units);
    public ISubstance<T> ConvertToBaseUnits();
    #endregion

}

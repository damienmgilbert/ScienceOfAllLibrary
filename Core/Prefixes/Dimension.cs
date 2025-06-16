//-----------------------------------------------------------------------
// <copyright file="Dimension.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;
public enum Dimension
{
    Time, Length, Mass, ElectricCurrent, Temperature, AmountOfSubstance, LuminousIntensity
}
// create an attribute to describe the dimension of a unit
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
public sealed class DimensionAttribute : Attribute
{

    #region Constructors
    public DimensionAttribute(Dimension dimension)
    {
        Dimension = dimension;
    }
    #endregion

    #region Public properties
    public Dimension Dimension { get; }
    #endregion

}

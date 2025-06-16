//-----------------------------------------------------------------------
// <copyright file="ISIPrefixBase.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;
public interface IPrefix
{

    #region Public properties
    double Base10Exponent { get; }
    PrefixeType Prefix { get; }
    decimal DecimalValue { get; }
    string Name { get; }
    string Symbol { get; }
    #endregion

}
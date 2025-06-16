//-----------------------------------------------------------------------
// <copyright file="SIPrefixBase.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ScienceOfAllLibrary.Core.Prefixes;
public abstract class BasePrefix : IPrefix
{

    #region Public properties
    public abstract double Base10Exponent { get; }
    public abstract decimal DecimalValue { get; }
    public abstract string Name { get; }
    public abstract PrefixeType Prefix { get; }
    public abstract string Symbol { get; }
    #endregion
}

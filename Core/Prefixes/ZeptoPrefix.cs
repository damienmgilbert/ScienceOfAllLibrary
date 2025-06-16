//-----------------------------------------------------------------------
// <copyright file="ZeptoPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class ZeptoPrefix : BasePrefix
{
    #region Public properties
    public override double Base10Exponent => -21;
    public override PrefixeType Prefix => PrefixeType.Zepto;
    public override decimal DecimalValue => 1e-21M;

    public override string Name => "Zepto";

    public override string Symbol => "z";
    #endregion
}

//-----------------------------------------------------------------------
// <copyright file="MilliPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class MilliPrefix : SIPrefixBase
{
    #region Public properties
    public override double Base10Exponent => -3;

    public override PrefixeType Prefix => PrefixeType.Milli;
    public override decimal DecimalValue => 1e-3M;

    public override string Name => "Milli";

    public override string Symbol => "m";
    #endregion
}

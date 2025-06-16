//-----------------------------------------------------------------------
// <copyright file="ExaPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class ExaPrefix : SIPrefixBase
{
    #region Public properties
    public override double Base10Exponent => 18;
    public override PrefixeType Prefix => PrefixeType.Exa;
    public override decimal DecimalValue => 1e18M;

    public override string Name => "Exa";

    public override string Symbol => "E";
    #endregion
}

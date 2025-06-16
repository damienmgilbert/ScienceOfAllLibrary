//-----------------------------------------------------------------------
// <copyright file="MegaPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class MegaPrefix : SIPrefixBase
{
    #region Public properties
    public override double Base10Exponent => 6;

    public override PrefixeType Prefix => PrefixeType.Mega;
    public override decimal DecimalValue => 1e6M;

    public override string Name => "Mega";

    public override string Symbol => "M";
    #endregion
}

//-----------------------------------------------------------------------
// <copyright file="GigaPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class GigaPrefix : SIPrefixBase
{
    #region Public properties
    public override double Base10Exponent => 9;

    public override PrefixeType Prefix => PrefixeType.Giga;

    public override decimal DecimalValue => 1e9M;

    public override string Name => "Giga";

    public override string Symbol => "G";
    #endregion
}

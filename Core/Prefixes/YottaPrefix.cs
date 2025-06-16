//-----------------------------------------------------------------------
// <copyright file="YottaPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class YottaPrefix : BasePrefix
{
    #region Public properties
    public override double Base10Exponent => 24;
    public override PrefixeType Prefix => PrefixeType.Yotta;
    public override decimal DecimalValue => 1e24M;

    public override string Name => "Yotta";

    public override string Symbol => "Y";
    #endregion
}

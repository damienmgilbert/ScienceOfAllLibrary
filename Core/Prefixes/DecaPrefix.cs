//-----------------------------------------------------------------------
// <copyright file="DecaPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class DecaPrefix : BasePrefix
{
    #region Public properties
    public override double Base10Exponent => 1;
    public override PrefixeType Prefix => PrefixeType.Deca;
    public override decimal DecimalValue => 1e1M;

    public override string Name => "Deca";

    public override string Symbol => "da";
    #endregion
}

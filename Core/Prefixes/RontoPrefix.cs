//-----------------------------------------------------------------------
// <copyright file="RontoPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class RontoPrefix : SIPrefixBase
{
    #region Public properties
    public override double Base10Exponent => -27;

    public override PrefixeType Prefix => PrefixeType.Ronto;

    public override decimal DecimalValue => 1e-27M;

    public override string Name => "Ronto";

    public override string Symbol => "r";
    #endregion
}

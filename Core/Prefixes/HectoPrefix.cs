//-----------------------------------------------------------------------
// <copyright file="HectoPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class HectoPrefix : SIPrefixBase
{
    #region Public properties
    public override double Base10Exponent => 2;

    public override PrefixeType Prefix => PrefixeType.Hecto;
    public override decimal DecimalValue => 1e2M;

    public override string Name => "Hecto";

    public override string Symbol => "h";
    #endregion
}

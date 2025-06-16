//-----------------------------------------------------------------------
// <copyright file="QuectoPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class QuectoPrefix : SIPrefixBase
{
    #region Public properties
    public override double Base10Exponent => -30;
    public override PrefixeType Prefix => PrefixeType.Quecto;
    public override decimal DecimalValue => 1e-30M;

    public override string Name => "Quecto";

    public override string Symbol => "q";
    #endregion
}
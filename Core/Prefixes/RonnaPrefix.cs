//-----------------------------------------------------------------------
// <copyright file="RonnaPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class RonnaPrefix : BasePrefix
{
    #region Public properties
    public override double Base10Exponent => 27;

    public override PrefixeType Prefix => PrefixeType.Ronna;
    public override decimal DecimalValue => 1e27M;

    public override string Name => "Ronna";

    public override string Symbol => "R";
    #endregion
}

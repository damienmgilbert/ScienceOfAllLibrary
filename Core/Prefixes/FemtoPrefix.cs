//-----------------------------------------------------------------------
// <copyright file="FemtoPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class FemtoPrefix : SIPrefixBase
{
    #region Public properties
    public override double Base10Exponent => -15;

    public override PrefixeType Prefix => PrefixeType.Femto;
    public override decimal DecimalValue => 1e-15M;

    public override string Name => "Femto";

    public override string Symbol => "f";
    #endregion
}

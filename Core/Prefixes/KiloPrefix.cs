//-----------------------------------------------------------------------
// <copyright file="KiloPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class KiloPrefix : SIPrefixBase
{
    #region Public properties
    public override double Base10Exponent => 3;

    public override PrefixeType Prefix => PrefixeType.Kilo;
    public override decimal DecimalValue => 1e3M;

    public override string Name => "Kilo";

    public override string Symbol => "k";
    #endregion
}

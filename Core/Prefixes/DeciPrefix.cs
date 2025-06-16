//-----------------------------------------------------------------------
// <copyright file="DeciPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class DeciPrefix : SIPrefixBase
{
    #region Public properties
    public override double Base10Exponent => -1;
    public override PrefixeType Prefix => PrefixeType.Deci;
    public override decimal DecimalValue => 1e-1M;

    public override string Name => "Deci";

    public override string Symbol => "d";
    #endregion
}

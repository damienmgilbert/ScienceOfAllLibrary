//-----------------------------------------------------------------------
// <copyright file="MicroPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class MicroPrefix : SIPrefixBase
{
    #region Public properties
    public override double Base10Exponent => -6;

    public override PrefixeType Prefix => PrefixeType.Micro;
    public override decimal DecimalValue => 1e-6M;

    public override string Name => "Micro";

    public override string Symbol => "μ";
    #endregion
}

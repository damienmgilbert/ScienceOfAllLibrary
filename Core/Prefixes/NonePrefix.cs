//-----------------------------------------------------------------------
// <copyright file="NonePrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class NonePrefix : SIPrefixBase
{
    #region Public properties
    public override double Base10Exponent => 0;

    public override PrefixeType Prefix => PrefixeType.Base;
    public override decimal DecimalValue => 1M;

    public override string Name => "None";

    public override string Symbol => string.Empty;
    #endregion
}

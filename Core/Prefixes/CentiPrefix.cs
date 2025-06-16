//-----------------------------------------------------------------------
// <copyright file="CentiPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class CentiPrefix : SIPrefixBase
{
    #region Public properties
    public override double Base10Exponent => -2;
    public override PrefixeType Prefix => PrefixeType.Centi;
    public override decimal DecimalValue => 1e-2M;

    public override string Name => "Centi";

    public override string Symbol => "c";
    #endregion
}

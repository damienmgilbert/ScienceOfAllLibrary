//-----------------------------------------------------------------------
// <copyright file="NanoPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class NanoPrefix : BasePrefix
{
    #region Public properties
    public override double Base10Exponent => -9;

    public override PrefixeType Prefix => PrefixeType.Nano;
    public override decimal DecimalValue => 1e-9M;

    public override string Name => "Nano";

    public override string Symbol => "n";
    #endregion
}

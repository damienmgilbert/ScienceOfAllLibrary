//-----------------------------------------------------------------------
// <copyright file="ZettaPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class ZettaPrefix : BasePrefix
{
    #region Public properties
    public override double Base10Exponent => 21;
    public override PrefixeType Prefix => PrefixeType.Zetta;
    public override decimal DecimalValue => 1e21M;

    public override string Name => "Zetta";

    public override string Symbol => "Z";
    #endregion
}

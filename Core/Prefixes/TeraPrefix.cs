//-----------------------------------------------------------------------
// <copyright file="TeraPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class TeraPrefix : BasePrefix
{
    #region Public properties
    public override double Base10Exponent => 12;

    public override decimal DecimalValue => 1e12M;
    public override PrefixeType Prefix => PrefixeType.Tera;
    public override string Name => "Tera";

    public override string Symbol => "T";
    #endregion
}

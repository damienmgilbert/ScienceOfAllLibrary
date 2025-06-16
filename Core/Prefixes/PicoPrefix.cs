//-----------------------------------------------------------------------
// <copyright file="PicoPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class PicoPrefix : BasePrefix
{
    #region Public properties
    public override double Base10Exponent => -12;

    public override PrefixeType Prefix => PrefixeType.Pico;
    public override decimal DecimalValue => 1e-12M;

    public override string Name => "Pico";

    public override string Symbol => "p";
    #endregion
}

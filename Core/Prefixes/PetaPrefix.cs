//-----------------------------------------------------------------------
// <copyright file="PetaPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

public class PetaPrefix : SIPrefixBase
{
    #region Public properties
    public override double Base10Exponent => 15;

    public override PrefixeType Prefix => PrefixeType.Peta;
    public override decimal DecimalValue => 1e15M;

    public override string Name => "Peta";

    public override string Symbol => "P";
    #endregion
}

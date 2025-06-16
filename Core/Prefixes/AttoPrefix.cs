//-----------------------------------------------------------------------
// <copyright file="AttoPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;
public class AttoPrefix : SIPrefixBase
{

    #region Public properties
    public override double Base10Exponent => -18;
    public override decimal DecimalValue => 1e-18M;
    public override string Name => "Atto";
    public override PrefixeType Prefix => PrefixeType.Atto;
    public override string Symbol => "a";
    #endregion

}

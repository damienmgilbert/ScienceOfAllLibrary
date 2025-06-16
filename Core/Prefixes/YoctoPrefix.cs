//-----------------------------------------------------------------------
// <copyright file="YoctoPrefix.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;
public class YoctoPrefix : SIPrefixBase
{
    #region Public properties
    public override double Base10Exponent => -24; public override decimal DecimalValue => 1e-24M; public override string Name => "Yocto"; public override string Symbol => "y";
    #endregion

}

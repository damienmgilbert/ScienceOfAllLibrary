//-----------------------------------------------------------------------
// <copyright file="SIPrefixBase.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ScienceOfAllLibrary.Core.Prefixes;
public abstract class SIPrefixBase : ISIPrefixBase
{

    #region Public properties
    public abstract double Base10Exponent { get; }
    public abstract decimal DecimalValue { get; }
    public abstract string Name { get; }
    public abstract PrefixeType Prefix { get; }
    public abstract string Symbol { get; }


    #endregion
}

// this class should be able to convert a ISIPrefix to another ISIPrefix by finding the conversion factor
public static class ISIPrefixBaseExtensions
{
    public static ISIPrefixBase ConvertTo(this ISIPrefixBase prefixBase, ISIPrefixBase toBase)
    {
        if (prefixBase == null) throw new ArgumentNullException(nameof(prefixBase));
        if (toBase == null) throw new ArgumentNullException(nameof(toBase));
        // Calculate the conversion factor
        decimal conversionFactor = (decimal)Math.Pow(10, toBase.Base10Exponent - prefixBase.Base10Exponent);
        // Create a new instance of the target prefix type with the converted value
        return new ConvertedSIPrefix(prefixBase, toBase, conversionFactor);
    }

    private class ConvertedSIPrefix : ISIPrefixBase
    {
        private readonly ISIPrefixBase _fromPrefix;
        private readonly ISIPrefixBase _toPrefix;
        private readonly decimal _conversionFactor;
        public ConvertedSIPrefix(ISIPrefixBase fromPrefix, ISIPrefixBase toPrefix, decimal conversionFactor)
        {
            _fromPrefix = fromPrefix ?? throw new ArgumentNullException(nameof(fromPrefix));
            _toPrefix = toPrefix ?? throw new ArgumentNullException(nameof(toPrefix));
            _conversionFactor = conversionFactor;
        }
        public double Base10Exponent => _toPrefix.Base10Exponent;
        public decimal DecimalValue => _fromPrefix.DecimalValue * _conversionFactor;
        public string Name => $"{_fromPrefix.Name} to {_toPrefix.Name}";
        public PrefixeType Prefix => _toPrefix.Prefix;
        public string Symbol => $"{_fromPrefix.Symbol} to {_toPrefix.Symbol}";
    }
}
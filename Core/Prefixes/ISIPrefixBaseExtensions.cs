//-----------------------------------------------------------------------
// <copyright file="SIPrefixBase.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.Core.Prefixes;

// this class should be able to convert a ISIPrefix to another ISIPrefix by finding the conversion factor
public static class ISIPrefixBaseExtensions
{
    public static IPrefix ConvertTo(this IPrefix prefixBase, IPrefix toBase)
    {
        if (prefixBase == null) throw new ArgumentNullException(nameof(prefixBase));
        if (toBase == null) throw new ArgumentNullException(nameof(toBase));
        // Calculate the conversion factor
        decimal conversionFactor = (decimal)Math.Pow(10, toBase.Base10Exponent - prefixBase.Base10Exponent);
        // Create a new instance of the target prefix type with the converted value
        return new ConvertedSIPrefix(prefixBase, toBase, conversionFactor);
    }

    private class ConvertedSIPrefix : IPrefix
    {
        private readonly IPrefix _fromPrefix;
        private readonly IPrefix _toPrefix;
        private readonly decimal _conversionFactor;
        public ConvertedSIPrefix(IPrefix fromPrefix, IPrefix toPrefix, decimal conversionFactor)
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
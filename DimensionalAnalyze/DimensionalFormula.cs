//-----------------------------------------------------------------------
// <copyright file="DimensionalFormula.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;
using System.Text;

namespace ScienceOfAllLibrary.DimensionalAnalyze;
/// <summary>
/// Represents dimensional formula as powers of fundamental dimensions e.g., Velocity = [L¹T⁻¹], Force = [ML¹T⁻²]
/// </summary>
public partial struct DimensionalFormula : IEquatable<DimensionalFormula>
{

    #region Struct fields
    private DimensionalPowers _powersStruct = new();
    #endregion

    #region Constructors
    private DimensionalFormula(DimensionalPowers powersStruct) { _powersStruct = powersStruct; }
    public DimensionalFormula(
        sbyte length,
        sbyte mass,
        sbyte time,
        sbyte current,
        sbyte temperature,
        sbyte amountOfSubstance,
        sbyte luminosity)
    { _powersStruct = new DimensionalPowers(length, mass, time, current, temperature, amountOfSubstance, luminosity); }
    #endregion

    #region Operators
    public static DimensionalFormula operator -(DimensionalFormula left, DimensionalFormula right)
    {
        if (!left.Equals(right))
            throw new DimensionalMismatchException($"Cannot subtract incompatible dimensions: {left} - {right}");
        return left;
    }
    /// <summary>
    ///
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator !=(DimensionalFormula left, DimensionalFormula right)
    {
        return !left.Equals(right);
    }
    public static DimensionalFormula operator *(DimensionalFormula left, DimensionalFormula right)
    {
        // use the powerStruct to multiply dimensions
        var length = (sbyte)(left._powersStruct.LengthDimension + right._powersStruct.LengthDimension);
        var mass = (sbyte)(left._powersStruct.MassDimension + right._powersStruct.MassDimension);
        var time = (sbyte)(left._powersStruct.TimeDimensions + right._powersStruct.TimeDimensions);
        var current = (sbyte)(left._powersStruct.CurrentDimensions + right._powersStruct.CurrentDimensions);
        var temperature = (sbyte)(left._powersStruct.TemperatureDimensions + right._powersStruct.TemperatureDimensions);
        var amountOfSubstance = (sbyte)(left._powersStruct.AmountOfSubstanceDimensions +
            right._powersStruct.AmountOfSubstanceDimensions);
        var luminosity = (sbyte)(left._powersStruct.LuminosityDimensions + right._powersStruct.LuminosityDimensions);
        DimensionalPowers resultStruct = new(
            length: length,
            mass: mass,
            time: time,
            current: current,
            temperature: temperature,
            amountOfSubstance: amountOfSubstance,
            luminosity: luminosity);
        return new DimensionalFormula(resultStruct);
    }
    public static DimensionalFormula operator /(DimensionalFormula left, DimensionalFormula right)
    {
        // use the powerStruct to divide dimensions
        sbyte lengthDimension = (sbyte)(left._powersStruct.LengthDimension - right._powersStruct.LengthDimension);
        sbyte massDimension = (sbyte)(left._powersStruct.MassDimension - right._powersStruct.MassDimension);
        sbyte timeDimension = (sbyte)(left._powersStruct.TimeDimensions - right._powersStruct.TimeDimensions);
        sbyte electricalCurrentDimension = (sbyte)(left._powersStruct.CurrentDimensions - right._powersStruct.CurrentDimensions);
        sbyte temperatureDimension = (sbyte)(left._powersStruct.TemperatureDimensions - right._powersStruct.TemperatureDimensions);
        sbyte amountOfSubstanceDimension = (sbyte)(left._powersStruct.AmountOfSubstanceDimensions - right._powersStruct.AmountOfSubstanceDimensions);
        sbyte luminosityDimension = (sbyte)(left._powersStruct.LuminosityDimensions - right._powersStruct.LuminosityDimensions);
        var resultStruct = new DimensionalPowers(
            length: lengthDimension,
            mass: massDimension,
            time: timeDimension,
            current: electricalCurrentDimension,
            temperature: temperatureDimension,
            amountOfSubstance: amountOfSubstanceDimension,
            luminosity: luminosityDimension);
        return new DimensionalFormula(resultStruct);
    }
    // Dimensional arithmetic
    public static DimensionalFormula operator +(DimensionalFormula left, DimensionalFormula right)
    {
        if (!left.Equals(right))
            throw new DimensionalMismatchException($"Cannot add incompatible dimensions: {left} + {right}");
        return left;
    }
    public static bool operator ==(DimensionalFormula left, DimensionalFormula right)
    {
        return left.Equals(right);
    }
    #endregion

    #region Indexers
    public sbyte this[FundamentalDimension dimension] => dimension switch
    {
        FundamentalDimension.Length => _powersStruct.LengthDimension,
        FundamentalDimension.Mass => _powersStruct.MassDimension,
        FundamentalDimension.Time => _powersStruct.TimeDimensions,
        FundamentalDimension.Current => _powersStruct.CurrentDimensions,
        FundamentalDimension.Temperature => _powersStruct.TemperatureDimensions,
        FundamentalDimension.AmountOfSubstance => _powersStruct.AmountOfSubstanceDimensions,
        FundamentalDimension.Luminosity => _powersStruct.LuminosityDimensions,
        _ => throw new ArgumentOutOfRangeException(nameof(dimension), "Invalid fundamental dimension")
    };
    #endregion

    #region Private methods
    private static string GetSuperscript(int power)
    {
        var superscripts = new Dictionary<char, char>
        {
            { '0', '⁰' },
            { '1', '¹' },
            { '2', '²' },
            { '3', '³' },
            { '4', '⁴' },
            { '5', '⁵' },
            { '6', '⁶' },
            { '7', '⁷' },
            { '8', '⁸' },
            { '9', '⁹' },
            { '-', '⁻' }
        };

        return new string(power.ToString().Select(c => superscripts.ContainsKey(c) ? superscripts[c] : c).ToArray());
    }
    #endregion

    #region Public methods
    public bool Equals(DimensionalFormula other)
    {
        // use powerStruct for equality check
        return _powersStruct.LengthDimension == other._powersStruct.LengthDimension &&
            _powersStruct.MassDimension == other._powersStruct.MassDimension &&
            _powersStruct.TimeDimensions == other._powersStruct.TimeDimensions &&
            _powersStruct.CurrentDimensions == other._powersStruct.CurrentDimensions &&
            _powersStruct.TemperatureDimensions == other._powersStruct.TemperatureDimensions &&
            _powersStruct.AmountOfSubstanceDimensions == other._powersStruct.AmountOfSubstanceDimensions &&
            _powersStruct.LuminosityDimensions == other._powersStruct.LuminosityDimensions;
    }
    public override bool Equals(object obj) { return obj is DimensionalFormula other && Equals(other); }
    public override int GetHashCode()
    {
        // use the powerStruct to calculate hash code

        var _powers = new[]
        {
            _powersStruct.LengthDimension,
            _powersStruct.MassDimension,
            _powersStruct.TimeDimensions,
            _powersStruct.CurrentDimensions,
            _powersStruct.TemperatureDimensions,
            _powersStruct.AmountOfSubstanceDimensions,
            _powersStruct.LuminosityDimensions
        };

        // Use a simple hash code calculation based on the powers
        // This is a basic implementation; consider using a more robust hash function for production code
        // e.g., using System.HashCode.Combine or a custom hash function
        // to avoid collisions in more complex scenarios
        if (_powers == null || _powers.Length != 7)
        {
            throw new InvalidOperationException("Invalid dimensional powers array length. Expected 7 elements.");
        }

        if (_powers.Any(p => p < -128 || p > 127))
        {
            throw new InvalidOperationException("Dimensional powers must be within the range of sbyte (-128 to 127).");
        }

        return _powers.Aggregate(0, (hash, power) => hash * 31 + power);
    }
    public DimensionalFormula Power(int exponent)
    {
        // user powerStuct to raise dimensions to a power

        _powersStruct = new DimensionalPowers(
            (sbyte)(_powersStruct.LengthDimension * exponent),
            (sbyte)(_powersStruct.MassDimension * exponent),
            (sbyte)(_powersStruct.TimeDimensions * exponent),
            (sbyte)(_powersStruct.CurrentDimensions * exponent),
            (sbyte)(_powersStruct.TemperatureDimensions * exponent),
            (sbyte)(_powersStruct.AmountOfSubstanceDimensions * exponent),
            (sbyte)(_powersStruct.LuminosityDimensions * exponent));
        return new DimensionalFormula(_powersStruct);
    }
    public DimensionalFormula Sqrt()
    {
        // user powerStruct to calculate square root of dimensions
        if (_powersStruct.LengthDimension % 2 != 0 ||
            _powersStruct.MassDimension % 2 != 0 ||
            _powersStruct.TimeDimensions % 2 != 0 ||
            _powersStruct.CurrentDimensions % 2 != 0 ||
            _powersStruct.TemperatureDimensions % 2 != 0 ||
            _powersStruct.AmountOfSubstanceDimensions % 2 != 0 ||
            _powersStruct.LuminosityDimensions % 2 != 0)
        {
            throw new InvalidOperationException("Cannot take square root of a dimensional formula with odd powers.");
        }

        return new DimensionalFormula(
            (sbyte)(_powersStruct.LengthDimension / 2),
            (sbyte)(_powersStruct.MassDimension / 2),
            (sbyte)(_powersStruct.TimeDimensions / 2),
            (sbyte)(_powersStruct.CurrentDimensions / 2),
            (sbyte)(_powersStruct.TemperatureDimensions / 2),
            (sbyte)(_powersStruct.AmountOfSubstanceDimensions / 2),
            (sbyte)(_powersStruct.LuminosityDimensions / 2));
    }
    public override string ToString()
    {
        if (IsDimensionless)
            return "1";

        var sb = new StringBuilder();

        // Use symbols for dimensions in the order: L, M, T, I, Θ, N, J
        // L = Length, M = Mass, T = Time, I = Electric Current, Θ = Temperature, N = Amount of Substance, J = Luminous Intensity
        var dimensionSymbols = new[] { "L", "M", "T", "I", "Θ", "N", "J" };


        // Append each dimension with its power, skipping dimensions with power 0
        // use the powerStruct to append dimensions, use a for loop that use attributes and reflection to iterate through the powers
        // powerStruct is a struct that contains the powers of each fundamental dimension, it does not use an array, but rather properties for each dimension

        foreach (var dimension in Enum.GetValues<FundamentalDimension>())
        {
            var power = this[dimension];
            if (power != 0)
            {
                sb.Append(dimensionSymbols[(int)dimension]);
                sb.Append(GetSuperscript(power));
            }
        }

        return sb.Length == 0 ? "1" : sb.ToString();
    }
    #endregion

    #region Public properties
    public bool IsDimensionless => _powersStruct.IsDimensionless();
    #endregion

}

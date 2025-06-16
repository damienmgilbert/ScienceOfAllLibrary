//-----------------------------------------------------------------------
// <copyright file="DimensionalFormula.DimensionalPowers.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace ScienceOfAllLibrary.DimensionalAnalyze;
public partial struct DimensionalFormula
{

    // turn the debug display into this format: [L¹M²T⁻³I⁰Θ⁰N⁰J⁰] for example
    /// <summary>
    /// Represents the powers of fundamental dimensions in a dimensional formula.
    /// </summary>
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi, Pack = 1, Size = 7)]
    private struct DimensionalPowers
    {

        #region Fields in type with StructLayout
        [FieldOffset(0)]
        public sbyte LengthDimension;  // L
        [FieldOffset(1)]
        public sbyte MassDimension;  // M
        [FieldOffset(2)]
        public sbyte TimeDimensions;  // T
        [FieldOffset(3)]
        public sbyte CurrentDimensions;  // I
        [FieldOffset(4)]
        public sbyte TemperatureDimensions;  // Θ
        [FieldOffset(5)]
        public sbyte AmountOfSubstanceDimensions;  // N
        [FieldOffset(6)]
        public sbyte LuminosityDimensions;  // J
        #endregion

        #region Constructors
        public DimensionalPowers()
        {
            LengthDimension = 0;
            MassDimension = 0;
            TimeDimensions = 0;
            CurrentDimensions = 0;
            TemperatureDimensions = 0;
            AmountOfSubstanceDimensions = 0;
            LuminosityDimensions = 0;
        }
        /// <summary>
        /// Initializes a new instance of the DimensionalPowers struct with specified powers for each fundamental dimension.
        /// </summary>
        /// <param name="length">Power of Length (L)</param>
        /// <param name="mass">Power of Mass (M)</param>
        /// <param name="time">Power of Time (T)</param>
        /// <param name="current">Power of Electric Current (I)</param>
        /// <param name="temperature">Power of Thermodynamic Temperature (Θ)</param>
        /// <param name="amountOfSubstance">Power of Amount of Substance (N)</param>
        /// <param name="luminosity">Power of Luminous Intensity (J)</param>
        public DimensionalPowers(sbyte length, sbyte mass, sbyte time, sbyte current, sbyte temperature, sbyte amountOfSubstance, sbyte luminosity)
        {
            LengthDimension = length;
            MassDimension = mass;
            TimeDimensions = time;
            CurrentDimensions = current;
            TemperatureDimensions = temperature;
            AmountOfSubstanceDimensions = amountOfSubstance;
            LuminosityDimensions = luminosity;
        }
        #endregion

        #region Private methods
        private string GetDebuggerDisplay()
        {
            var sb = new StringBuilder("[L");
            sb.Append(LengthDimension != 0 ? $"{GetSuperscript(LengthDimension)}" : "⁰");
            sb.Append("M");
            sb.Append(MassDimension != 0 ? $"{GetSuperscript(MassDimension)}" : "⁰");
            sb.Append("T");
            sb.Append(TimeDimensions != 0 ? $"{GetSuperscript(TimeDimensions)}" : "⁰");
            sb.Append("I");
            sb.Append(CurrentDimensions != 0 ? $"{GetSuperscript(CurrentDimensions)}" : "⁰");
            sb.Append("Θ");
            sb.Append(TemperatureDimensions != 0 ? $"{GetSuperscript(TemperatureDimensions)}" : "⁰");
            sb.Append("N");
            sb.Append(AmountOfSubstanceDimensions != 0 ? $"{GetSuperscript(AmountOfSubstanceDimensions)}" : "⁰");
            sb.Append("J");
            sb.Append(LuminosityDimensions != 0 ? $"{GetSuperscript(LuminosityDimensions)}" : "⁰");
            sb.Append("]");
            return sb.ToString();
        }
        #endregion

        #region Public methods
        public bool IsDimensionless()
        {
            bool dimensionlessLength = LengthDimension == 0;
            bool dimensionlessMass = MassDimension == 0;
            bool dimensionlessTime = TimeDimensions == 0;
            bool dimensionlessCurrent = CurrentDimensions == 0;
            bool dimensionlessTemperature = TemperatureDimensions == 0;
            bool dimensionlessAmountOfSubstance = AmountOfSubstanceDimensions == 0;
            bool dimensionlessLuminosity = LuminosityDimensions == 0;
            bool result = dimensionlessLength && dimensionlessMass && dimensionlessTime && dimensionlessCurrent && dimensionlessTemperature && dimensionlessAmountOfSubstance && dimensionlessLuminosity;
            return result;
        }
        #endregion

    }

}

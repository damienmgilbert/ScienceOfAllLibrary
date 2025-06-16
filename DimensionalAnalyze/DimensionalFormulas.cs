//-----------------------------------------------------------------------
// <copyright file="DimensionalFormulas.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.DimensionalAnalyze;
public static class DimensionalFormulas
{

    #region Public properties
    public static DimensionalFormula Acceleration => new(
        length: 1,
        mass: 0,
        time: -2,
        current: 0,
        temperature: 0,
        amountOfSubstance: 0,
        luminosity: 0);  // LT⁻²
    public static DimensionalFormula Area => new(
        length: 2,
        mass: 0,
        time: 0,
        current: 0,
        temperature: 0,
        amountOfSubstance: 0,
        luminosity: 0); // L²
    // Common dimensional formulas as static properties
    public static DimensionalFormula Dimensionless => new(
        length: 0,
        mass: 0,
        time: 0,
        current: 0,
        temperature: 0,
        amountOfSubstance: 0,
        luminosity: 0);
    public static DimensionalFormula Energy => new(
        length: 2,
        mass: 0,
        time: -2,
        current: 0,
        temperature: 0,
        amountOfSubstance: 0,
        luminosity: 0);        // ML²T⁻²
    public static DimensionalFormula Power => new(
        length: 2,
        mass: 0,
        time: -3,
        current: 0,
        temperature: 0,
        amountOfSubstance: 0,
        luminosity: 0);         // ML²T⁻³
    public static DimensionalFormula Speed => new(
        length: 1,
        mass: 0,
        time: -1,
        current: 0,
        temperature: 0,
        amountOfSubstance: 0,
        luminosity: 0);        // [L][T]⁻¹ - m/s
    public static DimensionalFormula Velocity => new(
        length: 1,
        mass: 0,
        time: -1,
        current: 0,
        temperature: 0,
        amountOfSubstance: 0,
        luminosity: 0);      // LT⁻¹
    #endregion

    public static class Fundamental
    {

        #region Public properties
        public static DimensionalFormula AmountOfSubstance => new(
            length: 0,
            mass: 0,
            time: 0,
            current: 0,
            temperature: 0,
            amountOfSubstance: 1,
            luminosity: 0); // [N] - mole
        public static DimensionalFormula ElectricCurrent => new(
            length: 0,
            mass: 0,
            time: 0,
            current: 1,
            temperature: 0,
            amountOfSubstance: 0,
            luminosity: 0);       // [I] - ampere
        public static DimensionalFormula Length => new(
            length: 1,
            mass: 0,
            time: 0,
            current: 0,
            temperature: 0,
            amountOfSubstance: 0,
            luminosity: 0);
        public static DimensionalFormula LuminousIntensity => new(
            length: 0,
            mass: 0,
            time: 0,
            current: 0,
            temperature: 0,
            amountOfSubstance: 0,
            luminosity: 1); // [J] - candela
        public static DimensionalFormula Mass => new(
            length: 0,
            mass: 1,
            time: 0,
            current: 0,
            temperature: 0,
            amountOfSubstance: 0,
            luminosity: 0);
        public static DimensionalFormula Temperature => new(
            length: 0,
            mass: 0,
            time: 0,
            current: 0,
            temperature: 1,
            amountOfSubstance: 0,
            luminosity: 0); // [Θ] - kelvin
        public static DimensionalFormula Time => new(
            length: 0,
            mass: 0,
            time: 1,
            current: 0,
            temperature: 0,
            amountOfSubstance: 0,
            luminosity: 0);
        #endregion

    }
    public static class Scalar
    {

        #region Fields
        public static DimensionalFormula AbsorbedDoseRate = new(
            length: 2,
            mass: 0,
            time: -3,
            current: 0,
            temperature: 0,
            amountOfSubstance: 0,
            luminosity: 0);
        public static DimensionalFormula Action = new(
            length: 2,
            mass: 1,
            time: -1,
            current: 0,
            temperature: 0,
            amountOfSubstance: 0,
            luminosity: 0);
        #endregion

        #region Public properties
        public static DimensionalFormula Force => new(
            length: 1,
            mass: 1,
            time: -2,
            current: 0,
            temperature: 0,
            amountOfSubstance: 0,
            luminosity: 0);
        public static DimensionalFormula Pressure => new(
            length: -1,
            mass: 1,
            time: -2,
            current: 0,
            temperature: 0,
            amountOfSubstance: 0,
            luminosity: 0);
        public static DimensionalFormula Volume => new(
            length: 3,
            mass: 0,
            time: 0,
            current: 0,
            temperature: 0,
            amountOfSubstance: 0,
            luminosity: 0); // L³
        #endregion

    }

;

}
//-----------------------------------------------------------------------
// <copyright file="DimensionalAnalysis.Constants.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace ScienceOfAllLibrary.DimensionalAnalyze;
public static partial class DimensionalAnalysis
{

    /// <summary>
    ///  Show the table here and there with the fundamental dimensions and their symbols
    /// <list type="bullet">"
    /// <item><term>L</term><description>Length</description></item>
    /// <item><term>M</term><description>Mass</description></item>
    /// <item><term>T</term><description>Time</description></item>
    /// <item><term>I</term><description>Electric Current</description></item>
    /// <item><term>Θ</term><description>Thermodynamic Temperature</description></item>
    /// <item><term>N</term><description>Amount of Substance</description></item>
    /// <item><term>J</term><description>Luminous Intensity</description></item>
    /// </summary>
    public static class Constants
    {

        #region Fields
        public static readonly PhysicalQuantity<double> AvogadroConstant = new(6.02214076e23, new DimensionalFormula(0, 0, 0, 0, 0, 1, 0)); // mol⁻¹
        public static readonly PhysicalQuantity<double> BoltzmannConstant = new(1.380649e-23, new DimensionalFormula(1, 2, -2, 0, 0, 0, 0)); // J K⁻¹
        public static readonly PhysicalQuantity<double> GasConstant = new
            (
                value: 8.31446261815324,
                dimension: new DimensionalFormula(length: 2, mass: 1, time: -2, current: 0, temperature: -1, amountOfSubstance: -1, luminosity: 0));
        public static readonly PhysicalQuantity<double> GravitationalConstant = new(6.67430e-11, new DimensionalFormula(1, -2, -1, 0, 0, 0, 0)); // m³ kg⁻¹ s⁻²
        public static readonly PhysicalQuantity<double> PlanckConstant = new(6.62607015e-34, new DimensionalFormula(1, 2, -1, 0, 0, 0, 0)); // J s
        public static readonly PhysicalQuantity<double> SpeedOfLight = new(299792458, new DimensionalFormula(1, 0, -1, 0, 0, 0, 0)); // m s⁻¹
        #endregion

    }

}

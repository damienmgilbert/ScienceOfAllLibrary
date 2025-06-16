//-----------------------------------------------------------------------
// <copyright file="DimensionalAnalysis.Formulas.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System.Numerics;

namespace ScienceOfAllLibrary.DimensionalAnalyze;
public static partial class DimensionalAnalysis
{

    /// <summary>
    /// Common physics formulas with dimensional checking
    /// </summary>
    public static class Formulas
    {

        #region Public methods
        public static PhysicalQuantity<T> IdealGasLawSolveForAmountOfSubstance<T>(
            PhysicalQuantity<T> pressure,
            PhysicalQuantity<T> volume,
            PhysicalQuantity<T> temperature)
            where T : INumber<T>
        {
            // Rearranging gives n = PV / (RT)
            return pressure * volume / (T.CreateChecked(Constants.GasConstant.Value) * temperature);
        }
        // updat the IdealGasLaw to use the GasConstant and solve for other variables
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pressure"></param>
        /// <param name="volume"></param>
        /// <param name="amount"></param>
        /// <param name="temperature"></param>
        /// <returns></returns>
        public static PhysicalQuantity<T> IdealGasLawSolveForGasConstant<T>(
            PhysicalQuantity<T> pressure,
            PhysicalQuantity<T> volume,
            PhysicalQuantity<T> amount,
            PhysicalQuantity<T> temperature)
            where T : INumber<T>
        {
            if (pressure.Dimension != DimensionalFormulas.Scalar.Pressure ||
                volume.Dimension != DimensionalFormulas.Scalar.Volume ||
                amount.Dimension != DimensionalFormulas.Fundamental.AmountOfSubstance ||
                temperature.Dimension != DimensionalFormulas.Fundamental.Temperature)
            {
                throw new ArgumentException("All quantities must have the correct dimensions for the Ideal Gas Law.");
            }

            // Ideal Gas Law: PV = nRT
            // Rearranging gives R = PV / (nT)
            PhysicalQuantity<T> flowEnergy = pressure * volume;



            PhysicalQuantity<T> thermalEnergy = (amount * temperature);
            PhysicalQuantity<T> moles = flowEnergy / thermalEnergy;
            return moles;
        }
        public static PhysicalQuantity<T> IdealGasLawSolveForPressure<T>(
            PhysicalQuantity<T> volume,
            PhysicalQuantity<T> amount,
            PhysicalQuantity<T> temperature)
            where T : INumber<T>
        {
            // Rearranging gives P = nRT / V
            return (amount * T.CreateChecked(Constants.GasConstant.Value) * temperature) / volume;
        }
        public static PhysicalQuantity<T> IdealGasLawSolveForTemperature<T>(
            PhysicalQuantity<T> pressure,
            PhysicalQuantity<T> volume,
            PhysicalQuantity<T> amount)
            where T : INumber<T>
        {
            // Rearranging gives T = PV / (nR)
            return (pressure * volume) / (amount * T.CreateChecked(Constants.GasConstant.Value));
        }
        public static PhysicalQuantity<T> IdealGasLawSolveForVolume<T>(
            PhysicalQuantity<T> pressure,
            PhysicalQuantity<T> amount,
            PhysicalQuantity<T> temperature)
            where T : INumber<T>
        {
            // Rearranging gives V = nRT / P
            return (amount * T.CreateChecked(Constants.GasConstant.Value) * temperature) / pressure;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="mass"></param>
        /// <param name="velocity"></param>
        /// <returns></returns>
        public static PhysicalQuantity<T> KineticEnergy<T>(PhysicalQuantity<T> mass, PhysicalQuantity<T> velocity)
            where T : INumber<T>
        {
            var half = T.One / (T.One + T.One);
            return half * mass * velocity.Power(2);
        }
        public static PhysicalQuantity<T> NewtonSecondLaw<T>(PhysicalQuantity<T> mass, PhysicalQuantity<T> acceleration)
            where T : INumber<T>
        {
            return mass * acceleration; // Should yield Force dimension
        }
        public static PhysicalQuantity<T> WorkEnergyTheorem<T>(
            PhysicalQuantity<T> force,
            PhysicalQuantity<T> displacement)
            where T : INumber<T>
        {
            return force * displacement; // Should yield Energy dimension
        }
        #endregion

    }

}

//-----------------------------------------------------------------------
// <copyright file="Example.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------


using ScienceOfAllLibrary.DimensionalAnalyze;

using System;

using System.Linq;

// Example usage demonstrating the engine
public class Example
{

    #region Public methods
    public static void DemonstrateEngine()
    {
        // Create physical quantities
        var mass = PhysicalQuantity<double>.Mass(10.0);        // 10 kg
        var velocity = PhysicalQuantity<double>.Velocity(5.0);  // 5 m/s
        var time = PhysicalQuantity<double>.Time(2.0);         // 2 s

        var pressure = PhysicalQuantity<double>.Pressure(101325.0);

        // Calculate kinetic energy
        var kineticEnergy = DimensionalAnalysis.Formulas.KineticEnergy(mass, velocity);
        Console.WriteLine($"Kinetic Energy: {kineticEnergy}"); // Should be 125 [ML²T⁻²] (Joules)

        // Calculate acceleration
        var acceleration = velocity / time;
        Console.WriteLine($"Acceleration: {acceleration}"); // Should be 2.5 [LT⁻²] (m/s²)

        // Calculate force using F = ma
        var force = DimensionalAnalysis.Formulas.NewtonSecondLaw(mass, acceleration);
        Console.WriteLine($"Force: {force}"); // Should be 25 [MLT⁻²] (Newtons)

        try
        {
            // This should throw an exception - can't add length to time
            var invalid = PhysicalQuantity<double>.Length(5.0) + PhysicalQuantity<double>.Time(3.0);
        }
        catch (DimensionalMismatchException ex)
        {
            Console.WriteLine($"Caught expected error: {ex.Message}");
        }
    }
    #endregion

}
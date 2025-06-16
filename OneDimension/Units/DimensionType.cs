//-----------------------------------------------------------------------
// <copyright file="DimensionType.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ScienceOfAllLibrary.OneDimension.Units;

public enum SIUnit
{
    [PhysicalUnit("Meter", "The SI unit of length.", "m")]
    Meter = 1,

    [PhysicalUnit("Kilogram", "The SI unit of mass.", "kg")]
    Kilogram = 2,

    [PhysicalUnit("Second", "The SI unit of time.", "s")]
    Second = 3,

    [PhysicalUnit("Ampere", "The SI unit of electric current.", "A")]
    Ampere = 4,

    [PhysicalUnit("Kelvin", "The SI unit of temperature.", "K")]
    Kelvin = 5,

    [PhysicalUnit("Mole", "The SI unit of amount of substance.", "mol")]
    Mole = 6,

    [PhysicalUnit("Candela", "The SI unit of luminous intensity.", "cd")]
    Candela = 7
}

[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
public class PhysicalUnitAttribute : Attribute
{
    public string Name { get; }
    public string Description { get; }
    public string Symbol { get; }
    public PhysicalUnitAttribute(string name, string description, string symbol)
    {
        Name = name;
        Description = description;
        Symbol = symbol;
    }
}

public enum DimensionType
{
    [Display(Name = "Length", Description = "The dimension of length.")]
    Length,

    [Display(Name = "Mass", Description = "The dimension of mass.")]
    Mass,

    [Display(Name = "Time", Description = "The dimension of time.")]
    Time,

    [Display(Name = "Electric Current", Description = "The dimension of electric current.")]
    ElectricCurrent,

    [Display(Name = "Temperature", Description = "The dimension of temperature.")]
    Temperature,

    [Display(Name = "Amount of Substance", Description = "The dimension of amount of substance.")]
    AmountOfSubstance,

    [Display(Name = "Luminous Intensity", Description = "The dimension of luminous intensity.")]
    LuminousIntensity
}

using System;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text.Json.Serialization;

using CommunityToolkit.Mvvm.ComponentModel;

using ScienceOfAllLibrary.Core;

namespace ScienceOfAllLibrary.OneDimension.Units;



public interface IBaseUnitType<T,E> : IObservableObject where T : INumber<T> where E : Enum
{
    /// <summary>
    /// Gets or sets the value of the current instance.
    /// </summary>
    T Value { get; set; }

    E BaseUnit { get; set; }

    string Description { get; set; }

    string Name { get; set; }

    string Symbol { get; set; }
    DimensionType Dimension { get; set; }
    E Units { get; set; }
}

public enum DimensionType
{
    None = 0,
    Length,
    Mass,
    Time,
    ElectricCurrent,
    Temperature,
    AmountOfSubstance,
    LuminousIntensity
}

public abstract class BaseDimension
{
    public DimensionType Dimension { get; set; }
    protected BaseDimension(DimensionType dimension)
    {
        Dimension = dimension;
    }
    public abstract string GetDimensionName();
}
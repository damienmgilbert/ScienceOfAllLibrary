//-----------------------------------------------------------------------
// <copyright file="PhysicalQuantity`1.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;
using System.Numerics;

namespace ScienceOfAllLibrary.DimensionalAnalyze;
/// <summary>
/// Represents a physical quantity with both numeric value and dimensional formula
/// </summary>
public struct PhysicalQuantity<T> : IEquatable<PhysicalQuantity<T>> where T : INumber<T>
{

    #region Struct fields
    DimensionalFormula dimension = new();
    T valueField;
    #endregion

    #region Constructors
    public PhysicalQuantity(T value, DimensionalFormula dimension)
    {
        valueField = value;
        this.dimension = dimension;
    }
    #endregion

    #region Operators
    public static PhysicalQuantity<T> operator -(PhysicalQuantity<T> left, PhysicalQuantity<T> right)
    {
        return new PhysicalQuantity<T>(left.Value - right.Value, left.Dimension - right.Dimension);
    }
    public static PhysicalQuantity<T> operator *(PhysicalQuantity<T> left, PhysicalQuantity<T> right)
    {
        T newValue = left.Value * right.Value;
        DimensionalFormula newDimensions = left.Dimension * right.Dimension;
        return new PhysicalQuantity<T>(newValue, newDimensions);
    }
    // Scalar operations
    public static PhysicalQuantity<T> operator *(T scalar, PhysicalQuantity<T> quantity)
    {
        return new PhysicalQuantity<T>(scalar * quantity.Value, quantity.Dimension);
    }
    public static PhysicalQuantity<T> operator *(PhysicalQuantity<T> quantity, T scalar)
    {
        return new PhysicalQuantity<T>(quantity.Value * scalar, quantity.Dimension);
    }
    public static PhysicalQuantity<T> operator /(PhysicalQuantity<T> left, PhysicalQuantity<T> right)
    {
        T value = left.Value / right.Value;
        DimensionalFormula dimension = left.Dimension / right.Dimension;
        return new PhysicalQuantity<T>(value, dimension);
    }
    public static PhysicalQuantity<T> operator /(PhysicalQuantity<T> quantity, T scalar)
    {
        return new PhysicalQuantity<T>(quantity.Value / scalar, quantity.Dimension);
    }
    public static PhysicalQuantity<T> operator +(PhysicalQuantity<T> left, PhysicalQuantity<T> right)
    {
        return new PhysicalQuantity<T>(left.Value + right.Value, left.Dimension + right.Dimension);
    }
    #endregion

    #region Public methods
    public static PhysicalQuantity<T> Acceleration(T value) { return new(value, DimensionalFormulas.Acceleration); }
    public static PhysicalQuantity<T> Amount(T value)
    { return new(value, DimensionalFormulas.Fundamental.AmountOfSubstance); }
    public static PhysicalQuantity<T> Dimensionless(T value) { return new(value, DimensionalFormulas.Dimensionless); }
    public static PhysicalQuantity<T> Energy(T value) { return new(value, DimensionalFormulas.Energy); }
    public bool Equals(PhysicalQuantity<T> other)
    { return Value.Equals(other.Value) && dimension.Equals(other.Dimension); }
    public override bool Equals(object obj) { return obj is PhysicalQuantity<T> other && Equals(other); }
    public static PhysicalQuantity<T> Force(T value) { return new(value, DimensionalFormulas.Scalar.Force); }
    public override int GetHashCode() { return HashCode.Combine(Value, dimension); }
    // Factory methods for common quantities
    public static PhysicalQuantity<T> Length(T value) { return new(value, DimensionalFormulas.Fundamental.Length); }
    public static PhysicalQuantity<T> LuminousIntensity(T value)
    { return new(value, DimensionalFormulas.Fundamental.LuminousIntensity); }
    public static PhysicalQuantity<T> Mass(T value) { return new(value, DimensionalFormulas.Fundamental.Mass); }
    public static PhysicalQuantity<T> Power(T value) { return new(value, DimensionalFormulas.Power); }
    // Power operations
    public PhysicalQuantity<T> Power(int exponent)
    {
        var result = Value;
        for (int i = 1; i < Math.Abs(exponent); i++)
        {
            result *= Value;
        }

        if (exponent < 0)
            result = T.One / result;

        return new PhysicalQuantity<T>(result, dimension.Power(exponent));
    }
    public static PhysicalQuantity<T> Pressure(T value) { return new(value, DimensionalFormulas.Scalar.Pressure); }
    public PhysicalQuantity<T> Sqrt()
    {
        // This is a simplified implementation - in practice you'd need proper nth root for generic T
        if (Value is double d)
        {
            var sqrtValue = (T)(object)Math.Sqrt(d);
            return new PhysicalQuantity<T>(sqrtValue, dimension.Sqrt());
        }
        throw new NotSupportedException($"Square root not implemented for type {typeof(T)}");
    }
    public static PhysicalQuantity<T> Temperature(T value)
    { return new(value, DimensionalFormulas.Fundamental.Temperature); }
    public static PhysicalQuantity<T> Time(T value) { return new(value, DimensionalFormulas.Fundamental.Time); }
    public override string ToString() { return $"{Value} [{dimension}]"; }
    public static PhysicalQuantity<T> Velocity(T value) { return new(value, DimensionalFormulas.Velocity); }
    public static PhysicalQuantity<T> Volume(T value) { return new(value, DimensionalFormulas.Scalar.Volume); }
    #endregion

    #region Public properties
    public DimensionalFormula Dimension { get => dimension; private set => dimension = value; }
    public T Value { get => valueField; set => valueField = value; }
    #endregion

}

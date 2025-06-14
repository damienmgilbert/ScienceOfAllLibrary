using System.Numerics;

using ScienceOfAllLibrary.OneDimension.Units;

namespace ScienceOfAllLibrary.OneDimension.Length;

public interface ILengthUnitType<T> : IBaseUnitType<T, LengthUnits> where T : INumber<T>
{
}
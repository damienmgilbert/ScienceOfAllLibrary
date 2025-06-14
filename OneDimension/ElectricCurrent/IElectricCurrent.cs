using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension.ElectricCurrent;
public interface IElectricCurrent<T> : IElectricCurrentUnitType<T> where T : INumber<T>, new()
{
    public IElectricCurrent<T> ConvertFrom(ElectricCurrentUnits units);
    public IElectricCurrent<T> ConvertToBaseUnit(); // Method to convert the value to the base unit
    public IElectricCurrent<T> ConvertTo(ElectricCurrentUnits units); // Method to change the units of the physical unit
}
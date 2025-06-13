using System;
using System.ComponentModel;
using System.Linq;

using CommunityToolkit.Mvvm.ComponentModel;

using ScienceOfAllLibrary.Core;

namespace ScienceOfAllLibrary.OneDimension.Units;



public interface IBaseUnitType<E> : IObservableObject where E : Enum
{
    E BaseUnit { get; set; }
    string Description { get; set; }
    string Name { get; set; }
    string Symbol { get; set; }
    E Units { get; set; }
}

//-----------------------------------------------------------------------
// <copyright file="IBaseUnitType`2.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using CommunityToolkit.Mvvm.ComponentModel;

using ScienceOfAllLibrary.Core;

using System;
using System.ComponentModel;
using System.Linq;

using System.Numerics;

using System.Text.Json.Serialization;

namespace ScienceOfAllLibrary.OneDimension.Units;
public interface IBaseUnitType<T, E> : IObservableObject where T : INumber<T> where E : Enum
{

    #region Public properties
    E BaseUnit { get; set; }
    string Description { get; set; }
    DimensionType Dimension { get; set; }
    string Name { get; set; }
    string Symbol { get; set; }
    E Units { get; set; }
    /// <summary>
    /// Gets or sets the value of the current instance.
    /// </summary>
    T Value { get; set; }
    #endregion

}

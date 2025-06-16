//-----------------------------------------------------------------------
// <copyright file="IMass.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ScienceOfAllLibrary.OneDimension.Mass;
public interface IMass<T> : IMassUnitType<T> where T : INumber<T>
{

    #region Public methods
    public IMass<T> ConvertFrom(MassUnits units);
    public IMass<T> ConvertTo(MassUnits units); // Method to change the units of the physical unit
    public IMass<T> ConvertToBaseUnit(); // Method to convert the value to the base unit
    #endregion

}

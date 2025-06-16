//-----------------------------------------------------------------------
// <copyright file="DimensionalMismatchException.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Linq;

namespace ScienceOfAllLibrary.DimensionalAnalyze;
/// <summary>
/// Exception thrown when dimensional analysis fails
/// </summary>
public class DimensionalMismatchException : InvalidOperationException
{

    #region Constructors
    public DimensionalMismatchException(string message) : base(message)
    {
    }
    public DimensionalMismatchException(string message, Exception innerException) : base(message, innerException)
    {
    }
    #endregion

}

//-----------------------------------------------------------------------
// <copyright file="IObservableObject.cs" company="">
//     Author:  
//     Copyright (c) . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceOfAllLibrary.Core;
public interface IObservableObject : INotifyPropertyChanged, INotifyPropertyChanging
{
}

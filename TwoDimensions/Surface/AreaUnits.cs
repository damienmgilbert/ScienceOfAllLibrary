using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using ScienceOfAllLibrary.OneDimension.Units;

namespace ScienceOfAllLibrary.TwoDimensions.Surface;
public enum AreaUnits
{
    SquareMeter, // Base unit for area
    SquareKilometer, // Common unit for large areas
    SquareCentimeter, // Common unit for small areas
    SquareMillimeter, // Used in precision engineering and scientific measurements
    SquareInch, // Common unit in the US for small areas
    SquareFoot, // Common unit in the US for larger areas
    SquareYard, // Common unit in the US and UK for larger areas
    Hectare, // Common unit for land area, especially in agriculture
    Acre, // Common unit for land area in the US and UK
    SquareMile, // Common unit for large land areas in the US and UK
    SquareDecimeter, // Used in some scientific contexts for small areas
    SquareMicrometer, // Used in precision engineering and scientific measurements
    SquareNanometer, // Used in nanotechnology and materials science
    SquarePicometer, // Used in theoretical physics and materials science
}

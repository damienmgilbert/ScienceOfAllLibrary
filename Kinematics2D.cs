using System.Diagnostics;
using System.Numerics;

namespace ScienceOfAllLibrary;

public class Kinematics2D
{
    public static System.Numerics.Vector2 ResultantDisplacementVector(System.Numerics.Vector2 initialPosition, System.Numerics.Vector2 finalPosition)
    {
        return finalPosition + initialPosition;
    }
}

public class Dynamics
{
    public static INumber<T> Force<T>(T mass, T acceleration) where T : INumber<T>
    {
        return mass * acceleration;
    }
}

public class TrigonometricIdentities
{

}

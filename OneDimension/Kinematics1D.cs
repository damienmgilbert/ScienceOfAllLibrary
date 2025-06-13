using System.Diagnostics.Contracts;
using System.Numerics;

namespace ScienceOfAllLibrary.OneDimension;

public class Kinematics1D
{
    public static T AverageSpeed<T>(T distance, TimeSpan time) where T : INumber<T>
    {
        if (time == TimeSpan.Zero)
        {
            throw new DivideByZeroException("Time cannot be zero when calculating average speed.");
        }
        return distance / T.CreateChecked(time.TotalSeconds);
    }

    public static T AverageVelocity<T>(T displacement, TimeSpan time) where T : INumber<T>
    {
        if (time == TimeSpan.Zero)
        {
            throw new DivideByZeroException("Time cannot be zero when calculating average velocity.");
        }
        return displacement / T.CreateChecked(time.TotalSeconds);
    }

    public static T AverageVelocity<T>(T initialVelocity, T finalVelocity) where T : INumber<T>
    {
        return (initialVelocity + finalVelocity) / T.CreateChecked(2);
    }

    public static T AverageAcceleration<T>(T changeInVelocity, TimeSpan time) where T : INumber<T>
    {
        if (time == TimeSpan.Zero)
        {
            throw new DivideByZeroException("Time cannot be zero when calculating average acceleration.");
        }
        return changeInVelocity / T.CreateChecked(time.TotalSeconds);
    }

    public static T Velocity<T>(T initialVelocity, T acceleration, TimeSpan time) where T : INumber<T>
    {
        return initialVelocity + acceleration * T.CreateChecked(time.TotalSeconds);
    }

    public static T Displacement<T>(T initialPosition, T initialVelocity, T acceleration, TimeSpan time) where T : INumber<T>
    {
        return initialPosition + initialVelocity * T.CreateChecked(time.TotalSeconds) + acceleration * T.CreateChecked(time.TotalSeconds) * T.CreateChecked(time.TotalSeconds) / T.CreateChecked(2);
    }

    public static T VelocitySquared<T>(T initialVelocity, T acceleration, T displacement) where T : INumber<T>
    {
        return initialVelocity * initialVelocity + T.CreateChecked(2) * acceleration * displacement;
    }

    public static INumber<double> AccelerationDueToGravity => 9.81;

    public static T Slope<T>(T deltaX, TimeSpan time) where T : INumber<T>
    {
        if (time == TimeSpan.Zero)
        {
            throw new DivideByZeroException("Time cannot be zero when calculating slope.");
        }
        return deltaX / T.CreateChecked(time.TotalSeconds);
    }
}

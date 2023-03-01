using System;
using System.Collections.Generic;

// TODO implement the IRemoteControlCar interface
public interface IRemoteControlCar
{
    int DistanceTravelled { get; }
    void Drive();
}


public class ProductionRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; private set; }
    public int NumberOfVictories { get; set; }

    public void Drive()
    {
        DistanceTravelled += 10;
    }
}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; private set; }

    public void Drive()
    {
        DistanceTravelled += 20;
    }
}

public static class TestTrack : IRemoteControlCar, IComparable<IRemoteControlCar>
{
    public static void Race(IRemoteControlCar car)
    {
        throw new NotImplementedException($"Please implement the (static) TestTrack.Race() method");
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        throw new NotImplementedException($"Please implement the (static) TestTrack.GetRankedCars() method");
    }
}

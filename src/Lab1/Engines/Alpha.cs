using Itmo.ObjectOrientedProgramming.Lab1.Service;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines;

public class Alpha : IEngine
{
    private const int StartFuelConsumed = 40;
    private const int FuelConsumedPerUnit = 50;
    private const int _speed = 20;
    private const int _flightRangeInTheSubspaceChannel = 100;

    public Fuel TypeOfFuel { get; } = Fuel.GravitonMatter;
    public int Speed => _speed;
    public int FlightRangeInTheSubspaceChannel => _flightRangeInTheSubspaceChannel;

    public int FuelConsumption(int distance)
    {
        return StartFuelConsumed + (FuelConsumedPerUnit * distance);
    }
}
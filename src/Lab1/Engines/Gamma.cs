using Itmo.ObjectOrientedProgramming.Lab1.Service;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines;

public class Gamma : IEngine
{
    private const int StartFuelConsumed = 140;
    private const int FuelConsumedPerUnit = 60;
    private const int _speed = 400;
    private const int _flightRangeInTheSubspaceChannel = 200;

    public Fuel TypeOfFuel { get; } = Fuel.GravitonMatter;
    public int Speed => _speed;
    public int FlightRangeInTheSubspaceChannel => _flightRangeInTheSubspaceChannel;

    public int FuelConsumption(int distance)
    {
        return StartFuelConsumed + ((FuelConsumedPerUnit * FuelConsumedPerUnit) * distance);
    }
}
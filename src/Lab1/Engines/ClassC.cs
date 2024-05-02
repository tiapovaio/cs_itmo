using Itmo.ObjectOrientedProgramming.Lab1.Service;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines;

public class ClassC : IEngine
{
    private const int FuelConsumedPerUnit = 10;
    private const int StartFuelConsumed = 15;
    private const int _speed = 10;
    private const int _flightRangeInTheSubspaceChannel = 0;

    public Fuel TypeOfFuel { get; } = Fuel.ActivePlasma;
    public int Speed => _speed;
    public int FlightRangeInTheSubspaceChannel => _flightRangeInTheSubspaceChannel;

    public int FuelConsumption(int distance)
    {
        return StartFuelConsumed + (FuelConsumedPerUnit * distance);
    }
}
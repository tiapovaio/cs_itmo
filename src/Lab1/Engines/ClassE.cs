using Itmo.ObjectOrientedProgramming.Lab1.Service;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines;

public class ClassE : IEngine
{
    private const int FuelConsumedPerUnit = 25;
    private const int StartFuelConsumed = 35;
    private const int SpeedOfEngine = 15;
    private const int FlightRangeInTheChannel = 0;

    public Fuel TypeOfFuel { get; } = Fuel.ActivePlasma;
    public int Speed => SpeedOfEngine;
    public int FlightRangeInTheSubspaceChannel => FlightRangeInTheChannel;
    public int FuelConsumption(int distance)
    {
        return StartFuelConsumed + (FuelConsumedPerUnit * distance);
    }
}
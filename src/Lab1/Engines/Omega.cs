using System;
using Itmo.ObjectOrientedProgramming.Lab1.Service;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines;

public class Omega : IEngine
{
    private const int StartFuelConsumed = 130;
    private const int FuelConsumedPerUnit = 55;
    private const int _speed = 86;
    private const int _flightRangeInTheSubspaceChannel = 150;

    public Fuel TypeOfFuel { get; } = Fuel.GravitonMatter;
    public int Speed => _speed;
    public int FlightRangeInTheSubspaceChannel => _flightRangeInTheSubspaceChannel;

    public int FuelConsumption(int distance)
    {
        return Convert.ToUInt16(StartFuelConsumed + ((FuelConsumedPerUnit * Math.Log(FuelConsumedPerUnit)) * distance));
    }
}
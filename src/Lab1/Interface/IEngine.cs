using Itmo.ObjectOrientedProgramming.Lab1.Service;
namespace Itmo.ObjectOrientedProgramming.Lab1;

public interface IEngine
{
    Fuel TypeOfFuel { get; }
    int Speed { get; }
    int FlightRangeInTheSubspaceChannel { get; }
    int FuelConsumption(int distance);
}
using Itmo.ObjectOrientedProgramming.Lab1.Service;
namespace Itmo.ObjectOrientedProgramming.Lab1;

public interface IShip
{
    bool IsAntiNitriteEmitterConnected { get; }
    Result Status { get; }
    IEngine ImpulseEngine { get; }
    IEngine? JumpEngine { get; }
    IDeflector PhotonDeflector { get; }
    IDeflector? Deflector { get; }
    IHull Hull { get; }
    int FlightTime(IEnvironment environment);

    void StatusSet(Result result);
}
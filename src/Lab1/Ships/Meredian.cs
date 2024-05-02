using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Service;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public class Meredian : IShip
{
    private IDeflector _deflector = new SecondClass();
    private IHull _hull = new Hulls.SecondClass();
    private IEngine _impulseEngine = new ClassE();
    private Result _status;
    private IDeflector _photonDeflector = new PhotonDeflector();

    public Meredian(StatusOfDeflector photondeflector)
    {
        _photonDeflector.SetConnectStatus(photondeflector);
    }

    public bool IsAntiNitriteEmitterConnected { get; } = true;
    public Result Status => _status;
    public IEngine ImpulseEngine => _impulseEngine;
    public IEngine? JumpEngine { get; }
    public IDeflector PhotonDeflector => _photonDeflector;
    public IDeflector? Deflector => _deflector;
    public IHull Hull => _hull;

    public void StatusSet(Result result)
    {
        _status = result;
    }

    public int FlightTime(IEnvironment environment)
    {
        return environment.Area / ImpulseEngine.Speed;
    }
}
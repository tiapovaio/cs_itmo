using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Service;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public class Augur : IShip
{
    private Result _status;
    private IHull _hull = new Hulls.ThirdClass();
    private IEngine _impulseEngine = new ClassE();
    private IEngine _jumpEngine = new Alpha();
    private IDeflector _photonDeflector = new PhotonDeflector();
    private IDeflector _deflector = new ThirdClass();

    public Augur(StatusOfDeflector photondeflector)
    {
        _photonDeflector.SetConnectStatus(photondeflector);
    }

    public bool IsAntiNitriteEmitterConnected { get; }
    public Result Status => _status;
    public IEngine ImpulseEngine => _impulseEngine;
    public IEngine? JumpEngine => _jumpEngine;
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
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Service;
using FirstClass = Itmo.ObjectOrientedProgramming.Lab1.Hulls.FirstClass;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships;

public class PleasureShuttle : IShip
{
    private Result _status;
    private IHull _hull = new FirstClass();
    private IEngine _impulseEngine = new ClassC();
    private IDeflector _photonDeflector = new PhotonDeflector();

    public PleasureShuttle(StatusOfDeflector photondeflector)
    {
        _photonDeflector.SetConnectStatus(photondeflector);
    }

    public bool IsAntiNitriteEmitterConnected { get; }
    public Result Status => _status;
    public IEngine ImpulseEngine => _impulseEngine;
    public IEngine? JumpEngine { get; }
    public IDeflector PhotonDeflector => _photonDeflector;
    public IDeflector? Deflector { get; }
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
using Itmo.ObjectOrientedProgramming.Lab1.Service;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public class AntimatterFlare : IAntimatterFlare
{
    private const int Damage = 1;
    public void Damaging(IShip ship)
    {
        if (ship.PhotonDeflector.Status != StatusOfDeflector.Connected) ship.StatusSet(Result.CrewIsKilled);
        else if (ship.PhotonDeflector.Damaging(Damage) != 0) ship.StatusSet(Result.CrewIsKilled);
    }
}
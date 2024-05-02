using Itmo.ObjectOrientedProgramming.Lab1.Service;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public class Meteorite : IAsteroidAndMeteorite
{
    private const int Damage = 20;

    public void Damaging(IShip ship)
    {
        if (ship.Deflector != null && ship.Deflector.Status == StatusOfDeflector.Connected)
        {
            int residualDamage = ship.Deflector.Damaging(Damage);
            if (residualDamage != 0 && ship.Hull.Hp < residualDamage) ship.StatusSet(Result.ShipIsDestroyed);
        }
        else if (ship.Hull.Hp < Damage)
        {
            ship.StatusSet(Result.ShipIsDestroyed);
        }
    }
}

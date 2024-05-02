using Itmo.ObjectOrientedProgramming.Lab1.Service;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public class CosmoWhale : ICosmoWhale
{
    private const int Damage = 50;
    public void Damaging(IShip ship)
    {
        if (ship.IsAntiNitriteEmitterConnected == false)
        {
            if (ship.Deflector == null || ship.Deflector.Status != StatusOfDeflector.Connected)
            {
                ship.StatusSet(Result.ShipIsDestroyed);
            }
            else
            {
                int residualDamage = ship.Deflector.Damaging(Damage);
                if (residualDamage != 0 && ship.Hull.Hp < residualDamage) ship.StatusSet(Result.ShipIsDestroyed);
            }
        }
    }
}
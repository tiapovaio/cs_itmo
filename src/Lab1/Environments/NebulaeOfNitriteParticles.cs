using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Engines;
using Itmo.ObjectOrientedProgramming.Lab1.Service;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public class NebulaeOfNitriteParticles : IEnvironment
{
    private readonly IList<IObstacle> _obstacles;
    private readonly int _area;
    private IEngine _reguiredEngine = new ClassE();

    public NebulaeOfNitriteParticles(IList<IObstacle> obstacles, int area)
    {
        foreach (IObstacle obstacle in obstacles)
        {
            if (obstacle is not ICosmoWhale) obstacles.Remove(obstacle);
        }

        _obstacles = obstacles;
        _area = area;
    }

    public int Area => _area;

    public void PassingTheSpace(IShip ship)
    {
        if (ship.ImpulseEngine.Speed != _reguiredEngine.Speed)
        {
            ship.StatusSet(Result.ShipLoss);
        }
        else
        {
            foreach (IObstacle obstacle in _obstacles)
            {
                obstacle.Damaging(ship);
            }
        }
    }
}
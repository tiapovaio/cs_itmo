using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Service;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public class NebulaeOfIncreaseOfSpace : IEnvironment
{
    private readonly IList<IObstacle> _obstacles;
    private readonly int _area;

    public NebulaeOfIncreaseOfSpace(IList<IObstacle> obstacles, int area)
    {
        foreach (IObstacle obstacle in obstacles)
        {
            if (obstacle is not IAntimatterFlare) obstacles.Remove(obstacle);
        }

        _obstacles = obstacles;
        _area = area;
    }

    public int Area => _area;

    public void PassingTheSpace(IShip ship)
    {
        if (ship.JumpEngine == null || Area > ship.JumpEngine.FlightRangeInTheSubspaceChannel)
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
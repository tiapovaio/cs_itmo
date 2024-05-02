using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments;

public class OrdynarySpace : IEnvironment
{
    private readonly List<IObstacle> _obstacles = new List<IObstacle>();
    private readonly int _area;

    public OrdynarySpace(IList<IObstacle> obstacles, int area)
    {
        foreach (IObstacle obstacle in obstacles)
        {
            if (obstacle is IAsteroidAndMeteorite)
            {
                _obstacles.Add(obstacle);
            }
        }

        _area = area;
    }

    public int Area => _area;

    public void PassingTheSpace(IShip ship)
    {
        foreach (IObstacle obstacle in _obstacles)
        {
            obstacle.Damaging(ship);
        }
    }
}
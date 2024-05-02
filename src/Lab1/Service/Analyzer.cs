using System.Collections.Generic;
using System.Linq;
namespace Itmo.ObjectOrientedProgramming.Lab1.Service;

public abstract class Analyzer
{
    public static IShip? ChoosingShip(IList<IShip> ships, IEnvironment environment)
    {
        foreach (IShip x in ships) environment.PassingTheSpace(x);

        var shipPassedTheSpace = ships.Where(x => x.Status == Result.Success).ToList();

        if (shipPassedTheSpace.Count == 0)
        {
            return null;
        }
        else
        {
            int minPrice = FuelExchange.PriceOfConsumedFuel(shipPassedTheSpace[0], environment);
            IShip bestChoise = shipPassedTheSpace[0];

            foreach (IShip x in shipPassedTheSpace)
            {
                if (minPrice > FuelExchange.PriceOfConsumedFuel(x, environment))
                {
                    bestChoise = x;
                    minPrice = FuelExchange.PriceOfConsumedFuel(x, environment);
                }
            }

            return bestChoise;
        }
    }
}

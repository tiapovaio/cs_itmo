namespace Itmo.ObjectOrientedProgramming.Lab1.Service;

public abstract class FuelExchange
{
    private const int PriceOfActivePlasma = 10;
    private const int PriceOfGravitonMatter = 15;

    public static int PriceOfConsumedFuel(IShip ship, IEnvironment environment)
    {
        if (ship.JumpEngine == null)
        {
            return ship.ImpulseEngine.FuelConsumption(environment.Area) * PriceOfActivePlasma;
        }
        else
        {
            return (ship.ImpulseEngine.FuelConsumption(environment.Area) * PriceOfActivePlasma) +
                   (ship.JumpEngine.FuelConsumption(environment.Area) * PriceOfGravitonMatter);
        }
    }
}
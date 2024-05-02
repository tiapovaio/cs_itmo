namespace Itmo.ObjectOrientedProgramming.Lab1.Service;

public class Route
{
    private IEnvironment _environmentRoute;
    private IShip _shipRoute;

    public Route(IEnvironment environment, IShip ship)
    {
        _environmentRoute = environment;
        _shipRoute = ship;
    }

    public void PassingRoute()
    {
        _environmentRoute.PassingTheSpace(_shipRoute);
    }
}
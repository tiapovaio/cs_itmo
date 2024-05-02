namespace Itmo.ObjectOrientedProgramming.Lab1;

public interface IEnvironment
{
    int Area { get; }
    void PassingTheSpace(IShip ship);
}
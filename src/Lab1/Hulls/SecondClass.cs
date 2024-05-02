namespace Itmo.ObjectOrientedProgramming.Lab1.Hulls;

public class SecondClass : IHull
{
    private const int HullHp = 35;
    private int _hp = HullHp;
    public int Hp => _hp;
}
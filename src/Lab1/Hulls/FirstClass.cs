namespace Itmo.ObjectOrientedProgramming.Lab1.Hulls;

public class FirstClass : IHull
{
    private const int HullHp = 30;
    private int _hp = HullHp;
    public int Hp => _hp;
}
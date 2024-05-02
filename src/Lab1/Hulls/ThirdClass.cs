namespace Itmo.ObjectOrientedProgramming.Lab1.Hulls;

public class ThirdClass : IHull
{
    private const int HullHp = 40;
    private int _hp = HullHp;
    public int Hp => _hp;
}
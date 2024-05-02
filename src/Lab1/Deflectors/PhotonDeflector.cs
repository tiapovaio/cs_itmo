using Itmo.ObjectOrientedProgramming.Lab1.Service;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors;

public class PhotonDeflector : IDeflector
{
    private const int Hp = 3;

    private int _hp = Hp;
    private StatusOfDeflector _status = StatusOfDeflector.Disconnected;

    public StatusOfDeflector Status => _status;

    public void SetConnectStatus(StatusOfDeflector status)
    {
        _status = status;
    }

    public int Damaging(int damage)
    {
        if (damage <= _hp)
        {
            _hp -= damage;
            return 0;
        }
        else
        {
            _hp = 0;
            _status = StatusOfDeflector.Destroyed;
            return damage - _hp;
        }
    }
}
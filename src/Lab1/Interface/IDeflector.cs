using Itmo.ObjectOrientedProgramming.Lab1.Service;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public interface IDeflector
{
    StatusOfDeflector Status { get; }
    void SetConnectStatus(StatusOfDeflector status);
    int Damaging(int damage);
}
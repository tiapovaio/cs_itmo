using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Topics;

public interface ITopic
{
    string Name { get; }
    IAddressee Addressee { get; }
    void SendMessage(IMessage message);
}
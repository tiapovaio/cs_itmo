using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Topics;

public class Topic : ITopic
{
    private string _name;
    private IAddressee _addressee;

    public Topic(string name, IAddressee addressee)
    {
        _name = name;
        _addressee = addressee;
    }

    public string Name => _name;
    public IAddressee Addressee => _addressee;

    public void SendMessage(IMessage message)
    {
        _addressee.SendMessage(message);
    }
}
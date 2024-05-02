using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class MockLogger
{
    private IAddressee? _addressee;
    public void SetAddressee(IAddressee addressee)
    {
        _addressee = addressee;
    }

    public string? SendMessage(IMessage message)
    {
            _addressee?.SendMessage(message);
            return message?.Body.ToString();
    }
}
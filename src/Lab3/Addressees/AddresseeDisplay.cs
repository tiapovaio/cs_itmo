using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Displays;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class AddresseeDisplay : IAddressee
{
    private IDisplay _display;

    public AddresseeDisplay(IDisplay display)
    {
        _display = display;
    }

    public IList<IMessage> CheckMessages => _display.Messages;

    public void SendMessage(IMessage message)
    {
        _display.SendMessage(message);
    }
}
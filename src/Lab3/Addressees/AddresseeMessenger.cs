using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Messengers;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class AddresseeMessenger : IAddressee
{
    private IMessenger _messenger;

    public AddresseeMessenger(IMessenger messenger)
    {
        _messenger = messenger;
    }

    public IList<IMessage> CheckMessages => _messenger.Messages;

    public void SendMessage(IMessage message)
    {
        _messenger.SendMessage(message);
    }
}
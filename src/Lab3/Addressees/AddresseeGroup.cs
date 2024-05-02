using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Groups;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class AddresseeGroup : IAddressee
{
    private IGroup _group;

    public AddresseeGroup(IGroup group)
    {
        _group = group;
    }

    public IList<IMessage> CheckMessages => _group.Messages;

    public void SendMessage(IMessage message)
    {
        _group.SendMessage(message);
    }
}
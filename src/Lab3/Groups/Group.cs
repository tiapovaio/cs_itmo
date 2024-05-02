using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Groups;

public class Group : IGroup
{
    private IList<IAddressee> _addressees = new List<IAddressee>();
    private IList<IMessage> _messages = new List<IMessage>();

    public Group(params IAddressee[] addressees)
    {
        foreach (IAddressee addressee in addressees)
        {
            _addressees.Add(addressee);
        }
    }

    public IList<IMessage> Messages => _messages;
    public void AddAddressee(IAddressee addressee)
    {
        _addressees.Add(addressee);
    }

    public void DeleteAddressee(IAddressee addressee)
    {
        _addressees.Remove(addressee);
    }

    public void SendMessage(IMessage message)
    {
        _messages.Add(message);
        foreach (IAddressee addressee in _addressees)
        {
            addressee.SendMessage(message);
        }
    }
}
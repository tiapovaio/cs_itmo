using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.MessagesWithStatus;
using Itmo.ObjectOrientedProgramming.Lab3.Users;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class AddresseeUser : IAddressee
{
    private IUser _user;

    public AddresseeUser(IUser user)
    {
        _user = user;
    }

    public IList<IMessageWithStatus> CheckMessages => _user.Messages;

    public void SendMessage(IMessage message)
    {
        _user.SendMessage(message);
    }
}
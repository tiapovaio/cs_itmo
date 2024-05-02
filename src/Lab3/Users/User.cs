using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.MessagesWithStatus;

namespace Itmo.ObjectOrientedProgramming.Lab3.Users;

public class User : IUser
{
    private List<IMessageWithStatus> _messagesWithStatus = new List<IMessageWithStatus>();

    public IList<IMessageWithStatus> Messages => _messagesWithStatus;

    public void SendMessage(IMessage message)
    {
        _messagesWithStatus.Add(new MessageWithStatus(message));
    }
}
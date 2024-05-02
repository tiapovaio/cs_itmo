using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.MessagesWithStatus;

namespace Itmo.ObjectOrientedProgramming.Lab3.Users;

public interface IUser
{
    IList<IMessageWithStatus> Messages { get; }

    void SendMessage(IMessage message);
}
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messengers;

public interface IMessenger
{
    IList<IMessage> Messages { get; }

    void SendMessage(IMessage message);
}
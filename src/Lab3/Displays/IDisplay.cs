using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public interface IDisplay
{
    IList<IMessage> Messages { get; }
    void SendMessage(IMessage message);
}
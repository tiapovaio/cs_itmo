using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class MockMessenger
{
    private List<IMessage> _messages = new List<IMessage>();

    public IList<IMessage> Messages => _messages;

    public string SendMessage(IMessage message)
    {
        _messages.Add(message);
        return "Messenger: " + message?.Body;
    }
}
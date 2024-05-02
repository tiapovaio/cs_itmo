using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public class Display : IDisplay
{
    private IList<IMessage> _messages = new List<IMessage>();
    public IList<IMessage> Messages => _messages;

    public void SendMessage(IMessage message)
    {
        _messages.Add(message);
        Console.WriteLine(message);
    }
}
using System;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Loggers;

public class Logger : ILogger
{
    public void ToLog(IMessage message)
    {
        Console.WriteLine(message.ToString());
    }
}
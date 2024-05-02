using System;
using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public static class DisplayDriver
{
    private static ConsoleColor _color;
    public static void Clean()
    {
        Console.Clear();
    }

    public static void SetColor(ConsoleColor color)
    {
        _color = color;
    }

    public static void Write(IMessage message, IAddressee addressee)
    {
        Console.ForegroundColor = _color;
        addressee.SendMessage(message);
    }
}
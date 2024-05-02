using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Loggers;

public interface ILogger
{
    void ToLog(IMessage message);
}
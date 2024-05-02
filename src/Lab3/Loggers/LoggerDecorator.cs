using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Loggers;

public class LoggerDecorator : IAddressee
{
    private IAddressee _addressee;
    private ILogger _logger;

    public LoggerDecorator(IAddressee addressee, ILogger logger)
    {
        _addressee = addressee;
        _logger = logger;
    }

    public void SendMessage(IMessage message)
    {
            _logger.ToLog(message);
            _addressee.SendMessage(message);
    }
}
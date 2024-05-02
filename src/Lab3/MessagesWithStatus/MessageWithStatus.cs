using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.MessagesWithStatus.Statuses;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessagesWithStatus;

public class MessageWithStatus : IMessageWithStatus
{
    private IMessage _message;
    private IMessageStatus _status = new MessageStatus();

    public MessageWithStatus(IMessage message)
    {
        _message = message;
    }

    public IMessage Message => _message;
    public IMessageStatus Status => _status;
}
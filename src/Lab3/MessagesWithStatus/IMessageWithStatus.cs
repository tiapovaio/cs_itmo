using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.MessagesWithStatus.Statuses;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessagesWithStatus;

public interface IMessageWithStatus
{
    IMessage Message { get; }
    IMessageStatus Status { get; }
}
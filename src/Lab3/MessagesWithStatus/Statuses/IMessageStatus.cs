using Itmo.ObjectOrientedProgramming.Lab3.Service;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessagesWithStatus.Statuses;

public interface IMessageStatus
{
    Status MyStatus { get; }
    void ChangeStatusToRead();
}
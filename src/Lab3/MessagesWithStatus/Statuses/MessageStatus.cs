using System;
using Itmo.ObjectOrientedProgramming.Lab3.Service;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessagesWithStatus.Statuses;

public class MessageStatus : IMessageStatus
{
    private Status _status = Status.Unread;

    public Status MyStatus => _status;

    public void ChangeStatusToRead()
    {
        if (_status == Status.Unread) _status = Status.Read;
        else throw new InvalidOperationException("Message has already been read");
    }
}
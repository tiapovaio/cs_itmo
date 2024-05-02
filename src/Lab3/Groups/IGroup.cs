using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Groups;

public interface IGroup
{
    IList<IMessage> Messages { get; }
    void AddAddressee(IAddressee addressee);
    void DeleteAddressee(IAddressee addressee);
    void SendMessage(IMessage message);
}
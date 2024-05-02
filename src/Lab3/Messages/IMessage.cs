using Itmo.ObjectOrientedProgramming.Lab3.Service;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messages;

public interface IMessage
{
    string Heading { get; }
    string Body { get; }
    ImportanceLevel Level { get; }
}
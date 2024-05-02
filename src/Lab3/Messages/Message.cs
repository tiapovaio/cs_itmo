using Itmo.ObjectOrientedProgramming.Lab3.Service;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messages;

public class Message : IMessage
{
    private string _heading;
    private string _body;
    private ImportanceLevel _level;

    public Message(string heading, string body, ImportanceLevel level)
    {
        _heading = heading;
        _body = body;
        _level = level;
    }

    public string Heading => _heading;
    public string Body => _body;
    public ImportanceLevel Level => _level;
}
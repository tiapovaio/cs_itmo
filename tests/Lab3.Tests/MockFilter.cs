using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Service;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class MockFilter
{
    private IAddressee? _addressee;
    private ImportanceLevel _level;
    private IMessage? _message;

    public bool SendMessage(IMessage message)
    {
        _message = message;
        if (_message.Level < ImportanceLevel.LeverSecond)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SetImportanceLevel(ImportanceLevel level)
    {
        _level = level;
    }

    public void SetAddressee(IAddressee addressee)
    {
        _addressee = addressee;
    }
}
using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Service;

namespace Itmo.ObjectOrientedProgramming.Lab3.Filters;

public class FilterProxi : IAddressee
{
    private IAddressee _addressee;
    private ImportanceLevel _level;

    public FilterProxi(IAddressee addressee, ImportanceLevel level)
    {
        _addressee = addressee;
        _level = level;
    }

    public void ChangeLevelOfImportance(ImportanceLevel level)
    {
        _level = level;
    }

    public void SendMessage(IMessage message)
    {
        if (message.Level < _level)
        {
            _addressee.SendMessage(message);
        }
    }
}
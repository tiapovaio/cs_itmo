using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class Ram : AbstractComponent
{
    private int _availableMemorySize;
    private IList<int> _supportedFrequencyAndVoltagePair = new List<int>();
    private IList<XmpProfile> _supportedXmpProfiles = new List<XmpProfile>();
    private string? _formFactor;
    private string? _ddrStandart;
    private int _powerConsumption;

    public int AvailableMemorySize => _availableMemorySize;
    public IList<int> SupportedFrequencyAndVoltagePair => _supportedFrequencyAndVoltagePair;
    public IList<XmpProfile> SupportedXmpProfiles => _supportedXmpProfiles;
    public string? FormFactor => _formFactor;
    public string? DdrStandart => _ddrStandart;
    public int PowerConsumption => _powerConsumption;

    public Ram WithMemorySize(int memory)
    {
        _availableMemorySize = memory;
        return this;
    }

    public Ram WithSupportedXmpProfiles(params XmpProfile[] xmpProfiles)
    {
        foreach (XmpProfile xmp in xmpProfiles)
        {
            _supportedXmpProfiles.Add(xmp);
        }

        return this;
    }

    public Ram WithFormFactor(string formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public Ram WithDdrStandart(string ddr)
    {
        _ddrStandart = ddr;
        return this;
    }

    public Ram WithPowerConsumption(int power)
    {
        _powerConsumption = power;
        return this;
    }
}
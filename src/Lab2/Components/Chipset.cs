using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class Chipset : AbstractComponent
{
    private IList<int> _supportedFrequencies = new List<int>();
    private bool _xmpProfile;

    public IList<int> SupportedFrequencies => _supportedFrequencies;
    public bool XmpProfile => _xmpProfile;

    public Chipset WithSupportedFrequencies(params int[] frequencies)
    {
        foreach (int frequency in frequencies)
        {
            _supportedFrequencies.Add(frequency);
        }

        return this;
    }

    public Chipset WithXmpProfile(bool presenceOfXmp)
    {
        _xmpProfile = presenceOfXmp;
        return this;
    }
}
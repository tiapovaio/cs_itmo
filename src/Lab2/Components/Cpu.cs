using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Service;

namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class Cpu : AbstractComponent
{
    private int _coreFrequency;
    private int _numberOfCores;
    private Sockets _socket;
    private bool _presenceOfBuildInVideoCore;
    private IList<int> _supportedMemoryFrequencies = new List<int>();
    private int _tdp;
    private int _powerConsumption;

    public int CoreFrequecy => _coreFrequency;
    public int NumberOfCores => _numberOfCores;
    public Sockets Soket => _socket;
    public bool PresenceOfBuildInVideoCore => _presenceOfBuildInVideoCore;
    public IList<int> SupportedMemoryFrequencies => _supportedMemoryFrequencies;
    public int Tdp => _tdp;
    public int PowerConsumption => _powerConsumption;

    public Cpu WithCoreFrequency(int frequency)
    {
        _coreFrequency = frequency;
        return this;
    }

    public Cpu WithNumberOfCores(int number)
    {
        _numberOfCores = number;
        return this;
    }

    public Cpu WithSocket(Sockets socket)
    {
        _socket = socket;
        return this;
    }

    public Cpu WithVideoCore(bool presence)
    {
        _presenceOfBuildInVideoCore = presence;
        return this;
    }

    public Cpu WithSupportedMemoryFrequencies(params int[] frequencies)
    {
        foreach (int frequency in frequencies)
        {
            _supportedMemoryFrequencies.Add(frequency);
        }

        return this;
    }

    public Cpu WithTdp(int tdp)
    {
        _tdp = tdp;
        return this;
    }

    public Cpu WithPowerConsumption(int power)
    {
        _powerConsumption = power;
        return this;
    }
}
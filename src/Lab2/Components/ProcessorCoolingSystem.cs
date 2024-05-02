using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Service;

namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class ProcessorCoolingSystem : AbstractComponent
{
    private int _dimensions;
    private IList<Sockets> _supportedSockets = new List<Sockets>();
    private int _maxTdp;

    public int Dimension => _dimensions;
    public IList<Sockets> Socket => _supportedSockets;
    public int MaxTdp => _maxTdp;

    public ProcessorCoolingSystem WithDimensions(int dimensions)
    {
        _dimensions = dimensions;
        return this;
    }

    public ProcessorCoolingSystem WithMaxTdp(int tdp)
    {
        _maxTdp = tdp;
        return this;
    }

    public ProcessorCoolingSystem WithSupportedSockets(params Sockets[] sockets)
    {
        foreach (Sockets socket in sockets)
        {
            _supportedSockets.Add(socket);
        }

        return this;
    }
}
using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class Bios : AbstractComponent
{
    private string? _type;
    private string? _version;
    private List<Cpu> _supportedCpus = new List<Cpu>();

    public string? Type => _type;
    public string? Version => _version;
    public IList<Cpu> SupportedCpus => _supportedCpus;

    public Bios WithType(string type)
    {
        _type = type;
        return this;
    }

    public Bios WithVersion(string version)
    {
        _version = version;
        return this;
    }

    public Bios WithSupportedCpus(params Cpu[] cpus)
    {
        foreach (Cpu cpu in cpus)
        {
            _supportedCpus.Add(cpu);
        }

        return this;
    }
}
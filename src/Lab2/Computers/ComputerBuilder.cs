using Itmo.ObjectOrientedProgramming.Lab2.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computers;

public class ComputerBuilder : IComputerBuilder
{
    private Bios? _bios;
    private Chipset? _chipset;
    private ComputerCase? _computerCase;
    private Cpu? _cpu;
    private Hdd? _hdd;
    private Motherboard? _motherboard;
    private ProcessorCoolingSystem? _processorCoolingSystem;
    private Psu? _psu;
    private Ram? _ram;
    private Ssd? _ssd;
    private Videocard? _videocard;
    private WiFiAdapter? _wifiAdapter;
    private XmpProfile? _xmpProfile;

    public Computer Build()
    {
        return new Computer(
            _bios,
            _chipset,
            _computerCase,
            _cpu,
            _hdd,
            _motherboard,
            _processorCoolingSystem,
            _psu,
            _ram,
            _ssd,
            _videocard,
            _wifiAdapter,
            _xmpProfile);
    }

    public IComputerBuilder WithBios(Bios bios)
    {
        _bios = bios;
        return this;
    }

    public IComputerBuilder WithChipset(Chipset chipset)
    {
        _chipset = chipset;
        return this;
    }

    public IComputerBuilder WithComputerCase(ComputerCase computerCase)
    {
        _computerCase = computerCase;
        return this;
    }

    public IComputerBuilder WithCpu(Cpu cpu)
    {
        _cpu = cpu;
        return this;
    }

    public IComputerBuilder WithHdd(Hdd hdd)
    {
        _hdd = hdd;
        return this;
    }

    public IComputerBuilder WithMotherboard(Motherboard motherboard)
    {
        _motherboard = motherboard;
        return this;
    }

    public IComputerBuilder WithProcessorCoolingSystem(ProcessorCoolingSystem processorCoolingSystem)
    {
        _processorCoolingSystem = processorCoolingSystem;
        return this;
    }

    public IComputerBuilder WithPsu(Psu psu)
    {
        _psu = psu;
        return this;
    }

    public IComputerBuilder WithRam(Ram ram)
    {
        _ram = ram;
        return this;
    }

    public IComputerBuilder WithSsd(Ssd ssd)
    {
        _ssd = ssd;
        return this;
    }

    public IComputerBuilder WithVideocard(Videocard videocard)
    {
        _videocard = videocard;
        return this;
    }

    public IComputerBuilder WithWiFiAdapter(WiFiAdapter wifiAdapter)
    {
        _wifiAdapter = wifiAdapter;
        return this;
    }

    public IComputerBuilder WithXmpProfile(XmpProfile xmpProfile)
    {
        _xmpProfile = xmpProfile;
        return this;
    }
}
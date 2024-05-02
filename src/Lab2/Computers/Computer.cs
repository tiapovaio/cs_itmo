using Itmo.ObjectOrientedProgramming.Lab2.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computers;

public class Computer
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

    public Computer(
        Bios? bios,
        Chipset? chipset,
        ComputerCase? computerCase,
        Cpu? cpu,
        Hdd? hdd,
        Motherboard? motherboard,
        ProcessorCoolingSystem? processorCoolingSystem,
        Psu? psu,
        Ram? ram,
        Ssd? ssd,
        Videocard? videocard,
        WiFiAdapter? wifiAdapter,
        XmpProfile? xmpProfile)
    {
        _bios = bios;
        _chipset = chipset;
        _computerCase = computerCase;
        _cpu = cpu;
        _hdd = hdd;
        _motherboard = motherboard;
        _processorCoolingSystem = processorCoolingSystem;
        _psu = psu;
        _ram = ram;
        _ssd = ssd;
        _videocard = videocard;
        _wifiAdapter = wifiAdapter;
        _xmpProfile = xmpProfile;
    }

    public Bios? GetBios => _bios;
    public Chipset? GetChipset => _chipset;
    public ComputerCase? GetComputerCase => _computerCase;
    public Cpu? GetCpu => _cpu;
    public Hdd? GetHdd => _hdd;
    public Motherboard? GetMotherboard => _motherboard;
    public ProcessorCoolingSystem? GetProcessorCoolingSystem => _processorCoolingSystem;
    public Psu? GetPsu => _psu;
    public Ram? GetRam => _ram;
    public Ssd? GetSsd => _ssd;
    public Videocard? GetVideocard => _videocard;
    public WiFiAdapter? GetWiFiAdapter => _wifiAdapter;
    public XmpProfile? GetXmpProfile => _xmpProfile;
}
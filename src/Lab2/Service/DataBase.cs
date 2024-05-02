using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Service;

public abstract class DataBase
{
    private IList<Bios> _bios = new List<Bios>();
    private IList<Chipset> _chipset = new List<Chipset>();
    private IList<ComputerCase> _computerCase = new List<ComputerCase>();
    private IList<Cpu> _cpu = new List<Cpu>();
    private IList<Hdd> _hdd = new List<Hdd>();
    private IList<Motherboard> _motherboard = new List<Motherboard>();
    private IList<ProcessorCoolingSystem> _processorCoolingSystem = new List<ProcessorCoolingSystem>();
    private IList<Psu> _psu = new List<Psu>();
    private IList<Ram> _ram = new List<Ram>();
    private IList<Ssd> _ssd = new List<Ssd>();
    private IList<Videocard> _videocard = new List<Videocard>();
    private IList<WiFiAdapter> _wifiAdapter = new List<WiFiAdapter>();
    private IList<XmpProfile> _xmpProfile = new List<XmpProfile>();

    public IList<Bios> Bioses => _bios;
    public IList<Chipset> Chipsets => _chipset;
    public IList<ComputerCase> ComputerCases => _computerCase;
    public IList<Cpu> Cpus => _cpu;
    public IList<Hdd> Hdds => _hdd;
    public IList<Motherboard> Motherboards => _motherboard;
    public IList<ProcessorCoolingSystem> ProcessorCoolingSystems => _processorCoolingSystem;
    public IList<Psu> Psus => _psu;
    public IList<Ram> Rams => _ram;
    public IList<Ssd> Ssds => _ssd;
    public IList<Videocard> Videocards => _videocard;
    public IList<WiFiAdapter> WifiAdapters => _wifiAdapter;
    public IList<XmpProfile> XmpProfiles => _xmpProfile;

    public void AddBios(Bios bios)
    {
        _bios.Add(bios);
    }

    public void AddChipset(Chipset chipset)
    {
        _chipset.Add(chipset);
    }

    public void AddComputerCase(ComputerCase computerCase)
    {
        _computerCase.Add(computerCase);
    }

    public void AddCpu(Cpu cpu)
    {
        _cpu.Add(cpu);
    }

    public void AddHdd(Hdd hdd)
    {
        _hdd.Add(hdd);
    }

    public void AddMotherboard(Motherboard motherboard)
    {
        _motherboard.Add(motherboard);
    }

    public void AddProcessorCoolingSystem(ProcessorCoolingSystem processorCoolingSystem)
    {
        _processorCoolingSystem.Add(processorCoolingSystem);
    }

    public void AddPsu(Psu psu)
    {
        _psu.Add(psu);
    }

    public void AddRam(Ram ram)
    {
        _ram.Add(ram);
    }

    public void AddSsd(Ssd ssd)
    {
        _ssd.Add(ssd);
    }

    public void AddVideocard(Videocard videocard)
    {
        _videocard.Add(videocard);
    }

    public void AddWifiAdapter(WiFiAdapter wiFiAdapter)
    {
        _wifiAdapter.Add(wiFiAdapter);
    }

    public void AddXmpProfile(XmpProfile xmpProfile)
    {
        _xmpProfile.Add(xmpProfile);
    }
}
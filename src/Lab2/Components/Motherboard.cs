using Itmo.ObjectOrientedProgramming.Lab2.Service;

namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class Motherboard : AbstractComponent
{
    private Sockets _socket;
    private int _numberOfPciELines;
    private int _numberOfSataPorts;
    private Chipset? _usedChipset;
    private string? _ddrStandart;
    private int _numberOfRamSlots;
    private string? _formFactor;
    private Bios? _supportedBios;

    public Sockets Soket => _socket;
    public int NumberOfPciLines => _numberOfPciELines;
    public int NumberOfSataPorts => _numberOfSataPorts;
    public Chipset? UsedChipset => _usedChipset;
    public string? DdrStandart => _ddrStandart;
    public int NumberOfRamSlots => _numberOfRamSlots;
    public string? FormFactor => _formFactor;
    public Bios? SupportedBios => _supportedBios;

    public Motherboard WithSocket(Sockets socket)
    {
        _socket = socket;
        return this;
    }

    public Motherboard WithNumberOfPciLines(int number)
    {
        _numberOfPciELines = number;
        return this;
    }

    public Motherboard WithNumberOfSataPorts(int number)
    {
        _numberOfSataPorts = number;
        return this;
    }

    public Motherboard WithNumberOfRamSlots(int number)
    {
        _numberOfRamSlots = number;
        return this;
    }

    public Motherboard WithChipset(Chipset chipset)
    {
        _usedChipset = chipset;
        return this;
    }

    public Motherboard WithDdrStandart(string standart)
    {
        _ddrStandart = standart;
        return this;
    }

    public Motherboard WithFormFactor(string formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public Motherboard WithBios(Bios bios)
    {
        _supportedBios = bios;
        return this;
    }
}
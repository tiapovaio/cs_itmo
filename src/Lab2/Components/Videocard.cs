namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class Videocard : AbstractComponent
{
    private int _dimension;
    private int _amountOfVideoMemory;
    private string? _versionOfPciE;
    private int _chipFrequancy;
    private int _powerConsumption;

    public int Dimension => _dimension;
    public int AmountOfVideoMemory => _amountOfVideoMemory;
    public string? VersionOfPciE => _versionOfPciE;
    public int ChipFrequency => _chipFrequancy;
    public int PowerConsumption => _powerConsumption;

    public Videocard WithDimensions(int dimension)
    {
        _dimension = dimension;
        return this;
    }

    public Videocard WithAmountOfVideoMemory(int memory)
    {
        _amountOfVideoMemory = memory;
        return this;
    }

    public Videocard WithVersionOfPciE(string versionOfPciE)
    {
        _versionOfPciE = versionOfPciE;
        return this;
    }

    public Videocard WithChipFrequancy(int frequency)
    {
        _chipFrequancy = frequency;
        return this;
    }

    public Videocard WithPowerConsumption(int power)
    {
        _powerConsumption = power;
        return this;
    }
}
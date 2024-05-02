namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class XmpProfile : AbstractComponent
{
    private string? _timing;
    private int _voltage;
    private int _frequency;

    public string? Timing => _timing;
    public int Voltage => _voltage;
    public int Frequency => _frequency;

    public XmpProfile WithVoltage(int voltage)
    {
        _voltage = voltage;
        return this;
    }

    public XmpProfile WithTiming(string timing)
    {
        _timing = timing;
        return this;
    }

    public XmpProfile WithFrequency(int frequency)
    {
        _frequency = frequency;
        return this;
    }
}
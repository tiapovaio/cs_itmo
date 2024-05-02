namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class Psu : AbstractComponent
{
    private int _peakLoad;

    public int PeakLoad => _peakLoad;

    public Psu WithPeakLoad(int peakLoad)
    {
        _peakLoad = peakLoad;
        return this;
    }
}
using System.Collections.Generic;
namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class ComputerCase : AbstractComponent
{
    private int _dimensions;
    private int _maxDimensionOfVideocard;
    private IList<string?> _supportedMotherboardFormFactors = new List<string?>();

    public int Dimensions => _dimensions;
    public int MaxDimensionOfVideocard => _maxDimensionOfVideocard;
    public IList<string?> SupportedMotherboardFormFactors => _supportedMotherboardFormFactors;

    public ComputerCase WithDimensions(int dimensions)
    {
        _dimensions = dimensions;
        return this;
    }

    public ComputerCase WithMaxDimensionOfVideocard(int dimensions)
    {
        _maxDimensionOfVideocard = dimensions;
        return this;
    }

    public ComputerCase WithSupportedMotherboardFormFactors(params string[] formFactors)
    {
        foreach (string formFactor in formFactors)
        {
            _supportedMotherboardFormFactors.Add(formFactor);
        }

        return this;
    }
}
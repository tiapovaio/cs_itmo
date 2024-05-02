using Itmo.ObjectOrientedProgramming.Lab2.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Computers;

public interface IComputerBuilder
{
    Computer Build();
    IComputerBuilder WithBios(Bios bios);
    IComputerBuilder WithChipset(Chipset chipset);
    IComputerBuilder WithComputerCase(ComputerCase computerCase);
    IComputerBuilder WithCpu(Cpu cpu);
    IComputerBuilder WithHdd(Hdd hdd);
    IComputerBuilder WithMotherboard(Motherboard motherboard);
    IComputerBuilder WithProcessorCoolingSystem(ProcessorCoolingSystem processorCoolingSystem);
    IComputerBuilder WithPsu(Psu psu);
    IComputerBuilder WithRam(Ram ram);
    IComputerBuilder WithSsd(Ssd ssd);
    IComputerBuilder WithVideocard(Videocard videocard);
    IComputerBuilder WithWiFiAdapter(WiFiAdapter wifiAdapter);
    IComputerBuilder WithXmpProfile(XmpProfile xmpProfile);
}
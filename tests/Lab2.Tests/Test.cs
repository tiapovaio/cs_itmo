using Itmo.ObjectOrientedProgramming.Lab2.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Computers;
using Itmo.ObjectOrientedProgramming.Lab2.Service;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tests;

public class Test
{
    private static Cpu _cpuA = new Cpu().
        WithCoreFrequency(10).
        WithNumberOfCores(10).
        WithSocket(Sockets.SocketA).
        WithVideoCore(false).
        WithSupportedMemoryFrequencies(10, 20).
        WithTdp(100).WithPowerConsumption(100);
    private static Chipset _chipsetA = new Chipset().
        WithSupportedFrequencies(10, 20).
        WithXmpProfile(true);
    private static Psu _psuA = new Psu().WithPeakLoad(1000);
    private static Psu _psuB = new Psu().WithPeakLoad(10);
    private static Bios _biosA = new Bios().
        WithType("TypeA").
        WithVersion("VersionFirst").
        WithSupportedCpus(_cpuA);
    private static ComputerCase _computerCaseA = new ComputerCase().
        WithDimensions(1000).
        WithMaxDimensionOfVideocard(50).
        WithSupportedMotherboardFormFactors("FormFactorA");
    private static ComputerCase _computerCaseB = new ComputerCase().
        WithDimensions(1000).
        WithMaxDimensionOfVideocard(50).
        WithSupportedMotherboardFormFactors("FormFactorB");
    private static Motherboard _motherboardA = new Motherboard().
        WithSocket(Sockets.SocketA).
        WithBios(_biosA).
        WithChipset(_chipsetA).
        WithDdrStandart("DdrStandartA").
        WithFormFactor("FormFactorA").
        WithNumberOfPciLines(10).
        WithNumberOfRamSlots(10).
        WithNumberOfSataPorts(10);
    private static XmpProfile _xmpProfileA = new XmpProfile().
        WithFrequency(10).
        WithTiming("18-18-36-53").
        WithVoltage(20);
    private static ProcessorCoolingSystem _coolingSystemA = new ProcessorCoolingSystem().
        WithDimensions(10).
        WithSupportedSockets(Sockets.SocketA).
        WithMaxTdp(10000);
    private static ProcessorCoolingSystem _coolingSystemB = new ProcessorCoolingSystem().
        WithDimensions(10).
        WithSupportedSockets(Sockets.SocketA).
        WithMaxTdp(10);
    private static Ram _ramA = new Ram().
        WithDdrStandart("DdrStandartA").
        WithFormFactor("FormFactorA").
        WithMemorySize(100).
        WithPowerConsumption(10).
        WithSupportedXmpProfiles(_xmpProfileA);
    private static Videocard _videocardA = new Videocard().
        WithDimensions(5).
        WithPowerConsumption(10).
        WithVersionOfPciE("VersionPciEA").
        WithChipFrequancy(20).
        WithAmountOfVideoMemory(100);
    private static Hdd _hddA = new Hdd().
        WithPowerConsumption(10).
        WithCapacity(100).
        WithSpindleRotationSpeed(10);

    private static Ssd _ssdA = new Ssd().
        WithCapacity(10).
        WithPowerConsumption(10).
        WithConnection(ConnectionOptions.PciE).
        WithMaxSpeed(10);
    private static WiFiAdapter _adapterA = new WiFiAdapter().
        WithPowerConsumption(10).
        WithVersionOfPciE("VersionPciEA").
        WithVersionOfWiFiStandart("StandartA").
        WithBluetoothModule(true);

    [Fact]
    public void TestSuitableComponents()
    {
        var builder = new ComputerBuilder();
        var configurator = new Configurator();
        builder.
            WithBios(_biosA).
            WithChipset(_chipsetA).
            WithComputerCase(_computerCaseA).
            WithCpu(_cpuA).
            WithHdd(_hddA).
            WithMotherboard(_motherboardA).
            WithProcessorCoolingSystem(_coolingSystemA).
            WithPsu(_psuA).
            WithRam(_ramA).
            WithSsd(_ssdA).
            WithVideocard(_videocardA).
            WithWiFiAdapter(_adapterA).
            WithXmpProfile(_xmpProfileA);
        configurator.GetChecklist(builder.Build());
        Assert.Equal(Result.Success, configurator.ResultOfBuilding());
    }

    [Fact]
    public void TestInsufficientPsuPower()
    {
        var builder = new ComputerBuilder();
        var configurator = new Configurator();
        builder.
            WithBios(_biosA).
            WithChipset(_chipsetA).
            WithComputerCase(_computerCaseA).
            WithCpu(_cpuA).
            WithHdd(_hddA).
            WithMotherboard(_motherboardA).
            WithProcessorCoolingSystem(_coolingSystemA).
            WithPsu(_psuB).
            WithRam(_ramA).
            WithSsd(_ssdA).
            WithVideocard(_videocardA).
            WithWiFiAdapter(_adapterA).
            WithXmpProfile(_xmpProfileA);
        configurator.GetChecklist(builder.Build());
        Assert.Equal(Result.Success, configurator.ResultOfBuilding());
    }

    [Fact]
    public void TestWeakCoolingSystemDisclaimerOfWarranty()
    {
        var builder = new ComputerBuilder();
        var configurator = new Configurator();
        builder.
            WithBios(_biosA).
            WithChipset(_chipsetA).
            WithComputerCase(_computerCaseA).
            WithCpu(_cpuA).
            WithHdd(_hddA).
            WithMotherboard(_motherboardA).
            WithProcessorCoolingSystem(_coolingSystemB).
            WithPsu(_psuA).
            WithRam(_ramA).
            WithSsd(_ssdA).
            WithVideocard(_videocardA).
            WithWiFiAdapter(_adapterA).
            WithXmpProfile(_xmpProfileA);
        configurator.GetChecklist(builder.Build());
        Assert.Equal(Result.Success, configurator.ResultOfBuilding());
    }

    [Fact]
    public void TestFailure()
    {
        var builder = new ComputerBuilder();
        var configurator = new Configurator();
        builder.
            WithBios(_biosA).
            WithChipset(_chipsetA).
            WithComputerCase(_computerCaseB).
            WithCpu(_cpuA).
            WithHdd(_hddA).
            WithMotherboard(_motherboardA).
            WithProcessorCoolingSystem(_coolingSystemA).
            WithPsu(_psuA).
            WithRam(_ramA).
            WithSsd(_ssdA).
            WithVideocard(_videocardA).
            WithWiFiAdapter(_adapterA).
            WithXmpProfile(_xmpProfileA);
        configurator.GetChecklist(builder.Build());
        Assert.Equal(Result.Failure, configurator.ResultOfBuilding());
    }
}
namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class WiFiAdapter : AbstractComponent
{
    private string? _versionOfWiFiStandart;
    private bool _buildInBluetoothModule;
    private string? _versionOfPciE;
    private int _powerConsumption;

    public string? VersionOfWiFiStandart => _versionOfWiFiStandart;
    public bool BuildInBluetoothModule => _buildInBluetoothModule;
    public string? VersionOfPciE => _versionOfPciE;
    public int PowerConsumption => _powerConsumption;

    public WiFiAdapter WithVersionOfWiFiStandart(string version)
    {
        _versionOfWiFiStandart = version;
        return this;
    }

    public WiFiAdapter WithBluetoothModule(bool presence)
    {
        _buildInBluetoothModule = presence;
        return this;
    }

    public WiFiAdapter WithVersionOfPciE(string version)
    {
        _versionOfPciE = version;
        return this;
    }

    public WiFiAdapter WithPowerConsumption(int power)
    {
        _powerConsumption = power;
        return this;
    }
}
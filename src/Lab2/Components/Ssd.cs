using Itmo.ObjectOrientedProgramming.Lab2.Service;

namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class Ssd : AbstractComponent
{
    private ConnectionOptions _connectionOption;
    private int _capacity;
    private int _maxSpeed;
    private int _powerConsumption;

    public ConnectionOptions ConnectionOption => _connectionOption;
    public int Capacity => _capacity;
    public int MaxSpeed => _maxSpeed;
    public int PowerConsumption => _powerConsumption;

    public Ssd WithConnection(ConnectionOptions connectionOption)
    {
        _connectionOption = connectionOption;
        return this;
    }

    public Ssd WithCapacity(int capacity)
    {
        _capacity = capacity;
        return this;
    }

    public Ssd WithMaxSpeed(int speed)
    {
        _maxSpeed = speed;
        return this;
    }

    public Ssd WithPowerConsumption(int power)
    {
        _powerConsumption = power;
        return this;
    }
}
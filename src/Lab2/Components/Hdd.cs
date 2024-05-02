namespace Itmo.ObjectOrientedProgramming.Lab2.Components;

public class Hdd : AbstractComponent
{
    private int _capacity;
    private int _spindleRotationSpeed;
    private int _powerConsumption;

    public int Capacity => _capacity;
    public int SpindleRotationSpeed => _spindleRotationSpeed;
    public int PowerConsumption => _powerConsumption;

    public Hdd WithCapacity(int capacity)
    {
        _capacity = capacity;
        return this;
    }

    public Hdd WithSpindleRotationSpeed(int speed)
    {
        _spindleRotationSpeed = speed;
        return this;
    }

    public Hdd WithPowerConsumption(int power)
    {
        _powerConsumption = power;
        return this;
    }
}
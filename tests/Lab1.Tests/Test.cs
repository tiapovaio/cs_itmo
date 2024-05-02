using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Environments;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Service;
using Itmo.ObjectOrientedProgramming.Lab1.Ships;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class Test
{
    public static IEnumerable<object[]> Data1()
    {
        yield return new object[] { new PleasureShuttle(StatusOfDeflector.Disconnected), Result.ShipLoss };
        yield return new object[] { new Augur(StatusOfDeflector.Disconnected), Result.ShipLoss };
    }

    public static IEnumerable<object[]> Data2()
    {
        yield return new object[] { new Vaclas(StatusOfDeflector.Disconnected), Result.CrewIsKilled };
        yield return new object[] { new Vaclas(StatusOfDeflector.Connected), Result.Success };
    }

    public static IEnumerable<object[]> Data3()
    {
        yield return new object[] { new Vaclas(StatusOfDeflector.Disconnected), Result.ShipIsDestroyed };
        yield return new object[] { new Augur(StatusOfDeflector.Disconnected), Result.Success };
        yield return new object[] { new Meredian(StatusOfDeflector.Disconnected), Result.Success };
    }

    [Theory]
    [MemberData(nameof(Data1))]
    public void TestNebulaOfIncreaseOfSpaceWalkingShuttleAndAugur(IShip ship, Result result)
    {
        IList<IObstacle> obstacles = new List<IObstacle> { };
        var environment = new NebulaeOfIncreaseOfSpace(obstacles, 200);
        var route = new Route(environment, ship);
        route.PassingRoute();
        Assert.Equal(result, ship.Status);
    }

    [Theory]
    [MemberData(nameof(Data2))]
    public void TestAntimatterFlameVaclasWithAndWithoutPhotonDeflector(IShip ship, Result result)
    {
        IList<IObstacle> obstacles = new List<IObstacle> { new AntimatterFlare() };
        var environment = new NebulaeOfIncreaseOfSpace(obstacles, 200);
        var route = new Route(environment, ship);
        route.PassingRoute();
        Assert.Equal(result, ship.Status);
    }

    [Theory]
    [MemberData(nameof(Data3))]
    public void TestCosmoWhaleInNebulaeOfNitriteParticles(IShip ship, Result result)
    {
        IList<IObstacle> obstacles = new List<IObstacle> { new CosmoWhale() };
        var environment = new NebulaeOfNitriteParticles(obstacles, 200);
        var route = new Route(environment, ship);
        route.PassingRoute();
        Assert.Equal(result, ship.Status);
    }

    [Fact]
    public void TestOrdynarySpace()
    {
        IList<IObstacle> obstacles = new List<IObstacle> { };
        var environment = new OrdynarySpace(obstacles, 100);
        var pleasureShuttle = new PleasureShuttle(StatusOfDeflector.Disconnected);
        var vaclas = new Vaclas(StatusOfDeflector.Disconnected);
        IList<IShip> ships = new List<IShip> { pleasureShuttle, vaclas };
        IShip? resultShip = Analyzer.ChoosingShip(ships, environment);
        if (resultShip != null)
        {
            Assert.Equal(pleasureShuttle, resultShip);
        }
    }

    [Fact]
    public void TestNebulaeOfIncreaseOfSpace()
    {
        IList<IObstacle> obstacles = new List<IObstacle> { };
        var environment = new NebulaeOfIncreaseOfSpace(obstacles, 200);
        var stella = new Stella(StatusOfDeflector.Disconnected);
        var augur = new Augur(StatusOfDeflector.Disconnected);
        IList<IShip> ships = new List<IShip> { stella, augur };
        IShip? resultShip = Analyzer.ChoosingShip(ships, environment);
        if (resultShip != null)
        {
            Assert.Equal(stella, resultShip);
        }
    }

    [Fact]
    public void TestNebulaeOfNitriteParticles()
    {
        IList<IObstacle> obstacles = new List<IObstacle> { new CosmoWhale() };
        var environment = new NebulaeOfNitriteParticles(obstacles, 200);
        var vaclas = new Vaclas(StatusOfDeflector.Disconnected);
        var pleasureShuttle = new PleasureShuttle(StatusOfDeflector.Disconnected);
        IList<IShip> ships = new List<IShip> { vaclas, pleasureShuttle };
        IShip? resultShip = Analyzer.ChoosingShip(ships, environment);
        if (resultShip != null)
        {
            Assert.Equal(vaclas, resultShip);
        }
    }

    [Fact]
    public void TestMyRoute()
    {
        IList<IObstacle> obstacles = new List<IObstacle> { };
        var environment = new NebulaeOfIncreaseOfSpace(obstacles, 200);
        var meredian = new Meredian(StatusOfDeflector.Disconnected);
        var pleasureShuttle = new PleasureShuttle(StatusOfDeflector.Disconnected);
        IList<IShip> ships = new List<IShip> { meredian, pleasureShuttle };
        IShip? resultShip = Analyzer.ChoosingShip(ships, environment);
        if (resultShip != null)
        {
            Assert.Equal(meredian, resultShip);
        }
    }
}

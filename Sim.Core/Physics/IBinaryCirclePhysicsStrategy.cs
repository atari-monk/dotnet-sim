namespace Sim.Core;

public interface IBinaryCirclePhysicsStrategy
{
    void CirclePhysis(
        double dt,
        IGameData gameData,
        params IShape[] circles);
}
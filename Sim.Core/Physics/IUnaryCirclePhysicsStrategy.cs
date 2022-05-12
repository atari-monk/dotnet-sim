namespace Sim.Core;

public interface IUnaryCirclePhysicsStrategy
{
    void CirclePhysis(
        IShape circle,
        double frameDeltaTime,
        IGameData gameData);
}
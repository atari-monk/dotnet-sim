namespace Sim.Core;

public interface ICirclesCollisonDuringFrame
    : IBinaryCirclePhysicsStrategy
{
    event Action<string> WhiteBallFirstCollisionEvent;

    void SetWhiteBallFirstCollisionHandler(Action<string> whiteBallFirstCollisionHandler);
}
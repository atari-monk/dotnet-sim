namespace Sim.Core;

public interface IBinaryLogic
{
    void BinaryLogic(IShape obj1
        , IShape obj2
        , double dt
        , IGameData data);
}
namespace Sim.Core;

public interface IShapesLogic
{
    void ShapesLogic(
        List<IShape> list
        , double dt
        , IGameData data);
}
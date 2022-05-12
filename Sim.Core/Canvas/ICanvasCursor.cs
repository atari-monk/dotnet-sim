namespace Sim.Core;

public interface ICanvasCursor<TModel>
    : ICanvasSerializaton<TModel>
{
    void SetCursor();
}
namespace Sim.Core;

public interface ICanvasVisualControl<TModel>
{
    ICanvasSerializaton<TModel> Canvas { get; }
}
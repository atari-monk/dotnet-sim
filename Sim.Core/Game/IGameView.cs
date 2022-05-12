namespace Sim.Core;

public interface IGameView
{
    ICanvasVisualControl<IShape> CanvasVisualControl { get; }
}
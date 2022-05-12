namespace Sim.Core;

public interface ICanvasEditorControl<TModel>
{
    ICanvasConfigDialog<TModel> Canvas { get; }
}
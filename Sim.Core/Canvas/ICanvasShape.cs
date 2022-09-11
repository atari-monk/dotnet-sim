using System.Windows.Input;
using System.Windows.Media;

namespace Sim.Core;

public interface ICanvasShape<TModel>
    : ICanvasBackground
{
    event EventHandler<MouseButtonEventArgs> GameInputEvent;

    Color Color { get; set; }

    Context Context { get; set; }

    bool Filled { get; set; }

    string Flag { get; set; }

    string Image { get; set; }

    double Radius { get; set; }

    ShapeTypes SelectedShape { get; set; }

    List<TModel>? Shapes { get; }

    double SizeHeight { get; set; }

    double SizeWidth { get; set; }

    void UpdateShapes();

    void AddShape(TModel shape);

    void RemoveShape(TModel shape);

    void Clear();
}
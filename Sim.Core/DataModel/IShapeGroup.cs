using System.Windows.Media;

namespace Sim.Core;

public interface IShapeGroup
{
    List<IShape> Group { get; set; }

    Visual[] GetShape();
}
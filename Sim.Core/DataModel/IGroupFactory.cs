using System.Windows;

namespace Sim.Core;

public interface IGroupFactory
{
    IShapeGroup GetShape(SelectedGroup selectedGroup, Point massCenter);
}
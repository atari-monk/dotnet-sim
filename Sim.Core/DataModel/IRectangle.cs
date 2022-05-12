using System.Windows;

namespace Sim.Core;

public interface IRectangle
    : IShape
{
    Size Size { get; set; }
}
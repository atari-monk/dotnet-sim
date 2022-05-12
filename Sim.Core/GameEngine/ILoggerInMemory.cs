using System.Collections.ObjectModel;

namespace Sim.Core;

public interface ILoggerToMemory
    : ILogger
{
    ObservableCollection<string> LogContent { get; }
}
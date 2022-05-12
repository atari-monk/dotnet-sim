namespace Sim.Core;

public interface ILoggerDisposeable 
    : ILogger
    , IDisposable
{
}
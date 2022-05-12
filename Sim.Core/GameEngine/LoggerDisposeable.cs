namespace Sim.Core;

public abstract class LoggerDisposeable
    : Logger
    , ILoggerDisposeable
{
    public abstract void Dispose();
}
namespace Sim.Core;

public abstract class Logger
    : ILogger
{
    public abstract void Log(string logMessage);
}
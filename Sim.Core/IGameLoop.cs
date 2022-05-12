namespace Sim.Core;

public interface IGameLoop
{
    event Action<GameStats> SetLabelEvent;

    void Log();

    void ProcessInput();

    void Render();

    void RunGameLoop();

    void Update(double ms);
}
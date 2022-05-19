using System.Windows.Input;

namespace Sim.Core;

public interface IBilliardGameContext
{
    event Action EndTurnEvent;

    event Action<PlayerStats> SetPlayer1StatsEvent;
    event Action<PlayerStats> SetPlayer2StatsEvent;

    ICanvasSerializaton<IShape> GameCanvas { get; }

    IGameData GameData { get; }

    IMovementState MovementState { get; }

    IPhysics Physics { get; }

    List<IShape> ScoredBilliardBalls { get; }

    ILoggerToMemory Logger { get; }

    IShape GetPlayer();

    bool IsMovementOnBilliardTable();

    void PlayerMove(object? sender, MouseButtonEventArgs mouseButtonEventArgs);

    void ScoreBilliardBall(IShape shape);

    void SetPlayer1Stats(PlayerStats playerStats);

    void SetPlayer2Stats(PlayerStats playerStats);

    void SetNoMovementState();

    void StartGame();
}
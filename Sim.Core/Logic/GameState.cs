namespace Sim.Core;

public abstract class GameState
    : IGameState
{
    public IBilliardGameMasterContext? Game { get; set; }

    public abstract void DoBeforeTurn();

    public virtual void DoAfterTurn() { }

    public virtual void DoAfterFoul() { }
}
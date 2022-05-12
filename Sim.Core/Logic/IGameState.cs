namespace Sim.Core;

public interface IGameState
{
    IBilliardGameMasterContext? Game { get; set; }

    void DoAfterFoul();

    void DoAfterTurn();

    void DoBeforeTurn();
}
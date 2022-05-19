using System.Windows.Input;

namespace Sim.Core;

public interface IBilliardGameMasterContext
    : IBilliardGameContext
{
    List<IFaulState> Fauls { get; set; }
    IFaulState FaulState { get; set; }
    IFaulState LastFaulState { get; set; }
    IBilliardPlayerManager PlayerMenager { get; set; }
    IGameState State { get; set; }

    void FixFaul();
    void HandleAfterTurn();
    void RestoreBlackBallAfterScoringIt(object? sender, MouseButtonEventArgs mouseArgs);
    void RestoreWhiteBallAfterScoringIt(object? sender, MouseButtonEventArgs mouseArgs);
    void SetScoreInfo();

    void SetBreakState(IGameState gameState);
    void SetOpenTableState(IGameState gameState);
    void SetTurnState(IGameState gameState);
    void SetWonState(IGameState gameState);
}
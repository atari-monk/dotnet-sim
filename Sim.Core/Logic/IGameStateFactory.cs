namespace Sim.Core;

public interface IGameStateFactory
{
    IGameState GetBreak(IGameState gameState);
    IGameState GetBreak(IBilliardGameMasterContext gameState);
    IGameState GetOpenTable(IGameState gameState);
    IGameState GetOpenTable(IBilliardGameMasterContext gameState);
    IGameState GetTurn(IGameState gameState);
    IGameState GetTurn(IBilliardGameMasterContext gameState);
    IGameState GetWonGame(IGameState gameState);
    IGameState GetWonGame(IBilliardGameMasterContext gameState);
}
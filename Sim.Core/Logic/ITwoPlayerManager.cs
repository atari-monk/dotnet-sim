namespace Sim.Core;

public interface ITwoPlayerManager
{
    IPlayer? PlayerInCurrentRound { get; set; }
    IPlayer? PlayerOne { get; set; }
    IPlayer? PlayerTwo { get; set; }

    void SwitchCurrentRoundPlayer();
}
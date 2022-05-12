namespace Sim.Core;

public interface IBilliardPlayerManager
    : ITwoPlayerManager
{
    IPlayer GetOther();

    void OpenTable(string flag);
}
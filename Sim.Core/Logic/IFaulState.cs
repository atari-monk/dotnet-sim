namespace Sim.Core;

public interface IFaulState
{
    IBilliardGameMasterContext? Game { get; set; }

    void FixFaul();

    bool IsFaulConditionMeet();
}
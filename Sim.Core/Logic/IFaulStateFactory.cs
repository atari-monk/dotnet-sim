namespace Sim.Core;

public interface IFaulStateFactory
{
    IFaulState GetBlackScoredInBreak(IFaulState faulState);
    IFaulState GetBlackScoredLast(IFaulState faulState);
    IFaulState GetBlackScoredNotLast(IFaulState faulState);
    IFaulState GetFixedFaul(IBilliardGameMasterContext context);
    IFaulState GetFixedFaul(IFaulState faulState);
    IFaulState GetNoFaul(IBilliardGameMasterContext context);
    IFaulState GetNoFaul(IFaulState faulState);
    IFaulState GetWhiteScored(IFaulState faulState);
}
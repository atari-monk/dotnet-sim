namespace Sim.Core;

public abstract class FaulState
    : IFaulState
{
    public IBilliardGameMasterContext? Game { get; set; }

    public abstract void FixFaul();

    public abstract bool IsFaulConditionMeet();

    protected bool IsBlackBallScored() => Game?.ScoredBilliardBalls.Find(ball => ball.TextFlag == "black") != null;

    protected bool IsWhiteBallScored() => Game?.ScoredBilliardBalls.Find(ball => ball.TextFlag == "white") != null;
}
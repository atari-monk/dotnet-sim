namespace Sim.Core;

public abstract class MovementState
    : IMovementState
{
    public IBilliardGameContext? Game { get; set; }
}
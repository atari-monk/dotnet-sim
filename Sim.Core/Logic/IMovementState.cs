namespace Sim.Core;

public interface IMovementState
{
    IBilliardGameContext? Game { get; set; }
}
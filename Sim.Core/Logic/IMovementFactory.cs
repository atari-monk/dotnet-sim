namespace Sim.Core;

public interface IMovementFactory
{
    IMovementState GetMovement(IMovementState movementState);
    IMovementState GetNoMovement(IBilliardGameContext gameContext);
    IMovementState GetNoMovement(IMovementState movementState);
}
namespace Sim.Core;

public interface IPhysics
{
    ICirclesCollisonDuringFrame BallCollisions { get; set; }

    void RunPhysics(double ms);
}
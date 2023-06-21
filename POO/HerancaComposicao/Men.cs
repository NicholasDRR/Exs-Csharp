namespace _Men;
using _Animal;
using _Walk;

public class Men : Animal
{
    private readonly WalkBehavior _walkBehavior;

    public Men(WalkBehavior walkBehavior)
    {
        this._walkBehavior = walkBehavior;
    }

    public void Locomotion()
    {
        System.Console.WriteLine(nameof(Men));
        _walkBehavior.Walk();
    }
}
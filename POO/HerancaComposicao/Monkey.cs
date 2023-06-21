namespace _Monkey;
using _Animal;
using _Walk;

public class Monkey : Animal
{
    private readonly WalkBehavior _walkBehavior;

    public Monkey(WalkBehavior walkBehavior)
    {
        this._walkBehavior = walkBehavior;
    }

    public void Locomotion()
    {
        System.Console.WriteLine(nameof(Monkey));
        _walkBehavior.Walk();
    }

}
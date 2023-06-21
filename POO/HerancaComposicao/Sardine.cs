namespace _Sardine;
using _Animal;
using _Swim;

public class Sardine : Animal
{
    private readonly SwimBehavior _swimBehavior;

    public Sardine(SwimBehavior swimBehavior)
    {
        this._swimBehavior = swimBehavior;
    }

    public void Locomotion()
    {
        System.Console.WriteLine(nameof(Sardine));
        _swimBehavior.Swim();
    }
}
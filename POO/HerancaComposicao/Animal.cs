namespace _Animal;

public abstract class Animal
{
    public int Age { get; set; }
    public void Eat()
    {
        System.Console.WriteLine("Eating...");
    }
    public void Sleep()
    {
        System.Console.WriteLine("Sleeping...");
    }
}
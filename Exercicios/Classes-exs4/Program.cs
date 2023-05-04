int foxPotency = 200;
Car fox = new();

int foxIncreasedPotency = fox.IncreasePotency(foxPotency);
System.Console.WriteLine($"Fox potency: {foxIncreasedPotency}");

foxIncreasedPotency = fox.IncreasePotency(ref foxPotency);
System.Console.WriteLine($"Fox potency: {foxIncreasedPotency}");

public class Car
{
    public int IncreasePotency(int potency)
    {
        return potency + 3;
    }
    public int IncreasePotency(ref int potency)
    {
        return potency + 5;
    }


}


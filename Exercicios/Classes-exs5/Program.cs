Car fox = new();
var foxPotency = fox.IncreasePotencySpeed(0, out double speed);

System.Console.WriteLine($"Potency: {foxPotency}");
System.Console.WriteLine($"Speed: {speed}");


public class Car 
{
    public double IncreasePotencySpeed(int potency, out double speed)
    {
        potency += 7;
        speed = Math.Pow(potency, 1.75);
        return  potency;
    }
}
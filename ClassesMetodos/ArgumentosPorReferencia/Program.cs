int x = 20;
System.Console.WriteLine($"X value: {x}");

Calculation calculation = new();
calculation._Double(ref x);

System.Console.WriteLine($"X value after method: {x}");

public class Calculation
{
    public void _Double(ref int y)
    {
        y *= 2;
        System.Console.WriteLine($"Y x 2: {y}");
    }
}
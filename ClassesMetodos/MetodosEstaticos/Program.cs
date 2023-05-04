int sum = Calculator.Sum(10,10);
int subtract = Calculator.Subtract(10,10);
int multiply = Calculator.Multiply(10,10);
int division = Calculator.Division(10,10);

System.Console.WriteLine($"X + Y = {sum}");
System.Console.WriteLine($"X - Y = {subtract}");
System.Console.WriteLine($"X * Y = {multiply}");
System.Console.WriteLine($"X / Y = {division}");


public class Calculator
{
    public static int Sum(int x, int y)
    {
        return x + y;
    }
    public static int Subtract(int x, int y)
    {
        return x - y;
    }
    public static int Multiply(int x, int y)
    {
        return x * y;
    }
    public static int Division(int x, int y)
    {
        return x / y;
    }
}
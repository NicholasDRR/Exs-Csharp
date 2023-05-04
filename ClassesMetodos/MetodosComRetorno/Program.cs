Operations operations = new();

var sum = operations.Sum(10, 10);
Console.WriteLine(sum);

var sub = operations.Subtraction(10, 10);
Console.WriteLine(sub);

var div = operations.Division(10, 10);
Console.WriteLine(div);

var mut = operations.Multiply(10, 10);
Console.WriteLine(mut);


public class Operations
{
    int number1;
    int number2;

    public int Sum (int n1, int n2)
    {
        return n1 + n2;
    }
    public int Subtraction(int n1, int n2)
    {
        return n1 - n2;
    }
    public int Division(int n1, int n2)
    {
        return n1 / n2;
    }
    public int Multiply(int n1, int n2)
    {
        return n1 * n2;
    }
}
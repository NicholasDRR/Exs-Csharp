Calculate calculate = new();

System.Console.WriteLine(calculate.Sum(30, 40));
System.Console.WriteLine(calculate.Sum(30, 40, 50));


class Calculate
{
    public int Sum (int num1, int num2)
    {
        return num1 + num2;
    }
    public int Sum (int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }


}
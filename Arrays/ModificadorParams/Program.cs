//int[] values = new int[5] {1,2,3,4,5};
//int total = Calculate.Sum(values);

int total = Calculate.Sum(1,2,3,4,5);
System.Console.WriteLine(total);

public class Calculate
{
    public static int Sum(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }
}
Car.IPVA_Value = 2.5;

System.Console.WriteLine($"IPVA Value: {Car.GetIPVA_Value()}");

public class Car
{
    public static double IPVA_Value;

    public static double GetIPVA_Value()
    {
        return IPVA_Value + 4;
    }
}
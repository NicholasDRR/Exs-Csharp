using Enum;

Console.WriteLine($"{Colors.White}  : {(int)Colors.White}");
Console.WriteLine($"{Colors.Red}    : {(int)Colors.Red}");
Console.WriteLine($"{Colors.Black}  : {(int)Colors.Black}");
Console.WriteLine($"{Colors.Gray}   : {(int)Colors.Gray}");
Console.WriteLine($"{Colors.Silver} : {(int)Colors.Silver}");
Console.WriteLine($"{Colors.Blue}   : {(int)Colors.Blue}");

Console.WriteLine("Desired color: ");
int carColor = Convert.ToInt32(Console.ReadLine());

Car ford = new(carColor);

ford.ShowInfo(carColor);

public class Car
{
    int Color;
    public Car(int color=1)
    {
        Color = color;
    }

    public void ShowInfo(int color=1)
    {
        System.Console.WriteLine($"Car color: {(Colors)color}");
    }


}
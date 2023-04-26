while (true)
{
    System.Console.WriteLine("\nEnter a number (999 to stop)");
    var number = Convert.ToInt32(Console.ReadLine());
    if (number == 999)
    {
        break;
    }
    if (number % 2 == 0)
    {
        System.Console.WriteLine($"{number} is a even number");
    }
    else
    {
        System.Console.WriteLine($"{number} is a odd number");
    }
}

int x = 0;

while (x < 6)
{   
    int y = 0;
    while (y < 6)
    {
        System.Console.WriteLine($"({x},{y})");
        y++;
    }
    x++;
}

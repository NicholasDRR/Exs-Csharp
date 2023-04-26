System.Console.WriteLine("Enter a number:");
var number = Convert.ToInt32(Console.ReadLine());
int init = 1;

if (number > 0)
{
    System.Console.WriteLine($"\nTabuada do {number}");
    while (init < 11)
    {
        
        System.Console.WriteLine($"{number} x {init} = {number * init}");
        init++;
    }
}
else
{
    System.Console.WriteLine("Enter a number greater than 0");
}
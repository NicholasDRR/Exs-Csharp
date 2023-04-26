System.Console.WriteLine("Enter an integer number greater than 0");
var number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    System.Console.WriteLine($"\nThe multiplication table of {number}");
    for (int init = 10; init > 0; init--)
    {
        System.Console.WriteLine($"{number} x {init} = {number*init}");
    }
}
else
{
    System.Console.WriteLine("Enter a number greater than 0");
}
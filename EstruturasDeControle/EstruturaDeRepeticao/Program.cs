int number = 1;

repeat:
    System.Console.WriteLine($"Number = {number}");
    number ++;

if (number <= 10)
{
    goto repeat;
}
System.Console.WriteLine("End processing");
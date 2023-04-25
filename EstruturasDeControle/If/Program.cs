System.Console.WriteLine("Special customer? (true/false)");
var answer = Convert.ToBoolean(Console.ReadLine());

if (answer)
{
    System.Console.WriteLine("10% discount\n");
}


System.Console.WriteLine("X value: ");
var x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Y value: ");
var y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    System.Console.WriteLine("X is bigger than Y");
}
if (x < y)
{
    System.Console.WriteLine("X is smaller than Y");
}
if (x == y)
{
    System.Console.WriteLine("X equals Y");
}
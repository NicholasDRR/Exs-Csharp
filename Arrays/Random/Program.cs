Random random = new(2023);

byte[] teste2 = new byte[10];
random.NextBytes(teste2);

System.Console.WriteLine("Bytes\n");
foreach(var item in teste2)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine("Nexts\n");
System.Console.WriteLine(random.Next());
System.Console.WriteLine(random.Next(1));
System.Console.WriteLine(random.Next(0, 10));
System.Console.WriteLine(random.NextDouble());

System.Console.WriteLine("Laço For\n");

for (int i = 0; i <=5; i++)
{
    System.Console.Write($"{random.Next(1, 10)} ");
}

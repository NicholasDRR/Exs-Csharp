System.Console.WriteLine("Atribuindo valores Float, Double, Decimal");
System.Console.WriteLine("");
float n2 = 1.234f;
double n1 = 1.234;
decimal n3;
n3 = 1.234m;

System.Console.WriteLine($" float: {n1}");
System.Console.WriteLine($" double: {n2}");
System.Console.WriteLine($" decimal: {n3}");

System.Console.WriteLine("");
System.Console.WriteLine("Comparando precisão");
System.Console.WriteLine("");
float x = 1f / 3f;
double y = 1d / 3d;
decimal z = 1m / 3m;

System.Console.WriteLine($"Float: {x}");
System.Console.WriteLine($"Double: {y}");
System.Console.WriteLine($"Decimal: {z}");
System.Console.WriteLine("");
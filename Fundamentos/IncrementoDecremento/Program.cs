Console.WriteLine("Incremento, Decremento!");

int x = 0;
System.Console.WriteLine($"\nX: {x}");

//pós-incremento
int resultado = x++ + 10;
System.Console.WriteLine($"Pós incremento: {resultado}");
System.Console.WriteLine($"Valor de X: {x}");

int y = 0;
System.Console.WriteLine($"\nY: {y}");
//pré-incremento
int resultado2 = ++y + 10;
System.Console.WriteLine($"Pré incremento: {resultado2}");
System.Console.WriteLine($"Valor de Y: {y}");
System.Console.WriteLine("");

//SUBTRAÇÃO

int z = 10;
System.Console.WriteLine($"\nZ: {z}");

int resultado3 = --z + 10;
System.Console.WriteLine($"Pré incremento: {resultado3}");
System.Console.WriteLine($"Valor de Z: {z}");
System.Console.WriteLine("");
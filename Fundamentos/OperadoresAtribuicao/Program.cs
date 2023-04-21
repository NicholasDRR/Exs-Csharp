Console.WriteLine("Operadores Atribuição");

var x = 10;

Console.WriteLine($"\nSoma 5: {x+=5}");
Console.WriteLine($"Subtrai 5: {x-=5}");
Console.WriteLine($"Multiplica 5: {x*=5}");
Console.WriteLine($"Divide 5: {x/=5}");
Console.WriteLine($"Módulo 5: {x%=5}");

string operador = "123";

Console.WriteLine($"\n{operador} + {456} = {operador+=456}");
Console.WriteLine($"{operador} + {789} = {operador+=789}");

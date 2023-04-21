Console.WriteLine("Operadores Aritméticos!");

Console.WriteLine("Informe o valor de X: ");
int x  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de Y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nRaiz quadrada de X = {Math.Sqrt(x)}");
Console.WriteLine($"X elevado a Y = {Math.Pow(x, y)}");
Console.WriteLine($"Valor mínimo entre x e Y = {Math.Min(x, y)}");
Console.WriteLine($"Valor máximo entre x e Y = {Math.Max(x, y)}");
Console.WriteLine($"Cosseno de X = {Math.Cos(x)}");
Console.WriteLine($"Seno de X = {Math.Sin(x)}");
Console.WriteLine($"Exponencial de X = {Math.Exp(x)}");
Console.WriteLine($"\nsoma de X e Y: {x + y}");
Console.WriteLine($"subtração de X e Y: {x - y}");
Console.WriteLine($"multiplicação de X e Y: {x * y}");
double? divisao = (double) x / y;
Console.WriteLine($"divisão de X e Y: {divisao}");
Console.WriteLine($"módulo de X e Y: {x % y}");

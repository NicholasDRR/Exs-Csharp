Console.WriteLine("Atribuindo valores para Bool e Char!");

sbyte x = 10;
sbyte y = 15;

bool ativo = true;
bool inativo = false;

char letra1 = '\u0041';
char letra2 = 'B';


System.Console.WriteLine("");
System.Console.WriteLine($"ativo == {ativo}");
System.Console.WriteLine($"inativo == {inativo}");
System.Console.WriteLine("");


System.Console.WriteLine($"{x} == {y}: {x == y}");
System.Console.WriteLine($"{x} == {x}: {x == x}");
System.Console.WriteLine($"{x} > {y}: {x > y}");
System.Console.WriteLine("");

System.Console.WriteLine(letra1);
System.Console.WriteLine(letra2);
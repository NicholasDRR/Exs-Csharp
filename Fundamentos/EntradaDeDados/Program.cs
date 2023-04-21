Console.WriteLine("Entrada de dados!");

System.Console.WriteLine("Informe seu nome:");
string? resposta = Console.ReadLine();

System.Console.WriteLine("Informe sua idade:");
int? idade = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Seu nome é {resposta}");
System.Console.WriteLine($"Sua idade é {idade}");
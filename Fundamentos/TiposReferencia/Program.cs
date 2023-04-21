Console.WriteLine("Definindo String, Object e Dynamic");

string nome = "Curso C#";

object nota = 10;
object valor = 9.30;
object nome1 = "Maria";
object ativa = true;
object letra = "A";

dynamic nota2 = 12;
dynamic valor2 = 9.32;
dynamic nome2 = "João";
dynamic ativa2 = false;
dynamic letra2 = "B";


Console.WriteLine("");
Console.WriteLine($"String: {nome}");
Console.WriteLine("");
Console.WriteLine($"Object: {nota}");
Console.WriteLine($"Object: {valor}");
Console.WriteLine($"Object: {nome1}");
Console.WriteLine($"Object: {ativa}");
Console.WriteLine($"Object: {letra}");
Console.WriteLine("");
Console.WriteLine($"Dynamic: {nota2}");
Console.WriteLine($"Dynamic: {valor2}");
Console.WriteLine($"Dynamic: {nome2}");
Console.WriteLine($"Dynamic: {ativa2}");
Console.WriteLine($"Dynamic: {letra2}");
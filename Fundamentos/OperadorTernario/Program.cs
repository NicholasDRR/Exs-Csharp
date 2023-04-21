Console.WriteLine("Operador ternário");

int numero, resultadoPositivo, resultadoNegativo;

System.Console.WriteLine("Informe um número: ");
//numero = Convert.ToInt32(Console.ReadLine());
numero = 99;

resultadoPositivo = +numero;
resultadoNegativo = -numero;

System.Console.WriteLine($"Resultado negativo: {resultadoNegativo}");
System.Console.WriteLine($"Resultado positivo: {resultadoPositivo}");

var n1 = 10;
var n2 = 12;
string n3;

n3 = n1 > n2 ? "N1 é maior": "N1 é menor";

System.Console.WriteLine(n3);
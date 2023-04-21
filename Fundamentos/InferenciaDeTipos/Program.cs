Console.WriteLine("Inferência de Tipos!");

//int idade = 25;
//string nome = "Maria";
//decimal salario = 2500m;

var idade = 25;
var nome = "Maria";
var salario = 2500m;

Console.WriteLine($"{nome} recebe {salario.ToString("c")} e tem {idade} anos");

//Limitações

var salario = null;
var titulo;
var salario, titulo;

// não é possível mudar o tipo após inicializar

var num = 10;
num = num + 20;
num = "Teste";

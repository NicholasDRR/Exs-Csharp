Console.WriteLine("Saída de dados: Formatação");
System.Console.WriteLine("");

int idade = 30;
string nome = "João";

/////////////////////////
System.Console.Write(nome);
System.Console.Write(" tem ");
System.Console.Write(idade);
System.Console.Write(" anos");
System.Console.WriteLine("");
/////////////////////////
System.Console.WriteLine(nome + " tem " + idade + " anos");
System.Console.Write(nome + " tem " + idade + " anos");
System.Console.WriteLine();
/////////////////////////
System.Console.Write($"{nome} tem {idade} anos");
System.Console.WriteLine();
System.Console.WriteLine($"{nome} tem {idade} anos");
/////////////////////////
System.Console.WriteLine("{0} tem {1} anos", nome, idade);
System.Console.Write("{0} tem {1} anos", nome, idade);
/////////////////////////
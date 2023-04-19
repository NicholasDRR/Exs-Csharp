Console.WriteLine("Nullable Types!");

//Nullable<int> variavel = null;
//Nullable<double> variavel2 = 1.2;
//Nullable<bool> variavel3 = false;
int? variavel = null;
double? variavel2 = 1.2;
bool? variavel3 = false;

//int? a = null;
//int b = a ?? 0; 
int? a = null;
int b = a ?? 0; //Se "a" for nulo, b recebe 0

//int? x = 4;
//int y = 2;
//int z = x * y;
int? x = 4;
int? y = 2;
int? z = x * y;

System.Console.WriteLine(z);
System.Console.WriteLine(b);
System.Console.WriteLine(variavel);
System.Console.WriteLine(variavel2);
System.Console.WriteLine(variavel3);


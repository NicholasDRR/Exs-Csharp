System.Console.WriteLine("Conversão de tipos 2: \n");

int ValorInt = 10;
double ValorDouble = 5.35;
bool ValorBool = true;

System.Console.WriteLine(Convert.ToString(ValorInt));
System.Console.WriteLine(Convert.ToDouble(ValorInt));
System.Console.WriteLine(Convert.ToString(ValorBool));
System.Console.WriteLine(Convert.ToInt32(ValorDouble));

int ValorInt1 = 10;
double ValorDouble1 = 12.45;
decimal ValorDecimal1 = 12.45678m;

string s1 = ValorInt1.ToString();
string s2 = ValorDouble1.ToString();
string s3 = ValorDecimal1.ToString();

System.Console.WriteLine(s1);   
System.Console.WriteLine(s2);   
System.Console.WriteLine(s3);   
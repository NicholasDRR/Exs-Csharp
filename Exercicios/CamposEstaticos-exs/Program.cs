
CheckingAccount c1 = new();

CheckingAccount.interest = 10;


c1.account = 123;
c1.name = "Vitoria";

CheckingAccount c2 = new();

c2.account = 124;
c2.name = "Kond";

System.Console.WriteLine($"Account: {c1.account}");
System.Console.WriteLine($"Name: {c1.name}");
System.Console.WriteLine($"Interest: {CheckingAccount.interest}");
System.Console.WriteLine($"Anual Interest: {c1.AnualInterest()}");

System.Console.WriteLine($"\nAccount: {c2.account}");
System.Console.WriteLine($"Name: {c2.name}");
System.Console.WriteLine($"Interest: {CheckingAccount.interest}");
System.Console.WriteLine($"Anual Interest: {c2.AnualInterest()}");


public class CheckingAccount
{
    public int account;
    public string name;
    public static int interest;

    public int AnualInterest()
    {
        return interest * 12;
    }
}
namespace BaseAccount;

public abstract class Account
{
    private decimal balance = 0;
    public decimal Balance
    {
        get{return balance;}
        set{balance = value;}

    }
    public int Number { get; set; }
    public string? ClientName { get; set; }

    public virtual void Deposit(int value) 
    {
        Balance += value;
    }
    public virtual void WithDraw(int value) 
    {
        Balance -= value;
    }
    public void ShowBalance()
    {

        System.Console.WriteLine($"Account number: {Number}");
        System.Console.WriteLine($"Name {ClientName}");
        System.Console.WriteLine($"Your balance: {Balance}");
    }


}
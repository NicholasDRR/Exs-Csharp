namespace BaseAccount;

public class Account
{
    private decimal balance;
    public decimal Balance
    {
        get{return balance;}
        
        set
        {
            if (value < 0)
            {
                value = 0;
            }
            else
            {
                balance = value;
            }
        }

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
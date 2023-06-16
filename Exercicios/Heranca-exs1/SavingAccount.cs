using BaseAccount;
namespace Saving;

public class SavingAccount : Account
{   

    public SavingAccount(int number, string clientName)
    {
        this.Number = number;
        this.ClientName = clientName;
    }

   public override void Deposit(int value) 
    {
       decimal interest = value * 0.05m;
       Balance += value - interest;
    }

    public override void WithDraw(int value) 
    {
        if (value > Balance)
        {
            System.Console.WriteLine($"Cannot withdraw, Balance: {Balance}");
        }
        else
        {
            Balance -= value;
        }
    }
}

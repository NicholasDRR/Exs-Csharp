using BaseAccount;
namespace Investment;


public class InvestmentAccount : Account
{
    public override void Deposit(int value) 
    {
       decimal interest = value * 0.09m;
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
            decimal tax = value * 0.01m;
            Balance -= value + tax;
        }
    }
    
}
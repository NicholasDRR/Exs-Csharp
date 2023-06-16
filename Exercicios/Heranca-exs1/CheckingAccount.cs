using BaseAccount;
namespace Checking;


public class CheckingAccount : Account
{
    public CheckingAccount(int number, string clientName)
    {
        this.Number = number;
        this.ClientName = clientName;
    }
}


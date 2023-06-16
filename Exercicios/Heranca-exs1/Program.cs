using Investment;
using Saving;
using Checking;

CheckingAccount checkingAccount = new(clientName: "Bruna", number: 15);

checkingAccount.Deposit(15);     
checkingAccount.WithDraw(19);    
checkingAccount.ShowBalance();   

// Account number: 15
// Name Bruna 
// Your balance: -4  


SavingAccount savingAccount = new(clientName: "Bruna", number: 15);

savingAccount.WithDraw(2);
savingAccount.ShowBalance();

// Cannot withdraw, Balance: 0
// Account number: 15
// Name Bruna
// Your balance: 0


InvestmentAccount investmentAccount = new(clientName: "Bruna", number: 15);

investmentAccount.Deposit(15);
investmentAccount.WithDraw(10);
investmentAccount.ShowBalance();

//Account number: 15
//Name Bruna
//Your balance: 3,55
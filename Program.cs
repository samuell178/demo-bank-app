 
using OOP;

BankAccount account1 = new BankAccount("Mickael Jones", "082983302330", 0);
// account1.AccountName = "Mickael Jones";
// account1.AccountNumber = "082983302330";
account1.Credit(3000);  
account1.Credit(5000);


var account2 = new BankAccount();
account2.AccountName = "Alhaji Sule";
account2.AccountNumber = "829299828308";
account2.Credit(300);
account2.Credit(660);
account1.WalletId = "ederdkjfdjkslksksffsfs";

Console.WriteLine($"My  account name is {account1.AccountName.ToUpper()} " +
$"with account number: {account1.AccountNumber} \n. My balance is ${account1.Balance} Crypto WalletId: {account1.WalletId}");

account1.Debit(7000);

Console.WriteLine("Account Balance = " + account1.Balance);
Console.WriteLine("Account2 Balance = " + account2.Balance);



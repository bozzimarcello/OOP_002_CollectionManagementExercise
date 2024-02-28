using BankConsoleApp;

BankAccount bankAccount = new BankAccount();

bankAccount.Deposit(100);

double balance = bankAccount.GetBalance();

Console.WriteLine($"New balance: {balance}");
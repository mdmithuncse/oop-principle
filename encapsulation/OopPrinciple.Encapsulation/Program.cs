// See https://aka.ms/new-console-template for more information
using OopPrinciple.Encapsulation;

Console.WriteLine("Hello, This is an example of encapsulation concept.");

BankAccount bankAccount = new BankAccount("2111856932449", "Alice", 10000);

Console.WriteLine($"Account Number: { bankAccount.GetAccountNumber() }");
Console.WriteLine($"Account Name: { bankAccount.GetAccountName() }");
Console.WriteLine($"Account Balance: {bankAccount.GetBalance()}");

bankAccount.Deposit(300);
bankAccount.Deposit(400);
bankAccount.Deposit(200);

bankAccount.Withdraw(100);
bankAccount.Withdraw(150);
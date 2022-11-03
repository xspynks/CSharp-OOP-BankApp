using OOP_ObjectsAndClasses;

var account = new BankAccount("Rafael", 1000);
var account2 = new BankAccount("Miguel", 3000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance} initial balance.");

account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, $"{account2.Owner} paid me back");
Console.WriteLine($"Current balance for {account.Owner}: {account.Balance}");
Console.WriteLine(account.GetAccountHistory());

// // Test for a negative balance.
// try
// {
//     account.MakeWithdrawal(1200, DateTime.Now, "Attempt to overdraw");
// }
// catch (InvalidOperationException e)
// {
//     Console.WriteLine("Exception caught trying to overdraw");
//     Console.WriteLine(e.ToString());
// }
//
// // Test that the initial balances must be positive.
// BankAccount invalidAccount;
// try
// {
//     invalidAccount = new BankAccount("invalid", -55);
// }
// catch (ArgumentOutOfRangeException e)
// {
//     Console.WriteLine("Exception caught creating account with negative balance");
//     Console.WriteLine(e.ToString());
//     return;
// }
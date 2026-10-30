namespace Banking.Console.Models;

public class CurrentAccount : Account
{
    public CurrentAccount(string accountNumber, string ownerName, decimal balance) : base(accountNumber,ownerName, balance)
    {
        
    }
}
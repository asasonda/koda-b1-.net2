namespace Banking.Console.Models.Account;

public class Account
{
    private string AccountNumber {get; set;}
    private string OwnerName {get; set;}
    private decimal Balance {get; set;}

    public Account(string accountNumber, string ownerName, decimal balance)
    {
        if(accountNumber == null)
        {
            throw new ArgumentException("Account Number is required");
        }

        if(ownerName == null)
        {
            throw new ArgumentException("Owner Name is required");
        }

        if(balance <= 0)
        {
            throw new ArgumentException("Balance negative number");
        }

        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = balance;
    }

    public string GetInformationAccounts()
    {
        return $"Account Number: {AccountNumber}\nName: {OwnerName}\nBalance: {Balance}";
    }
}
namespace Banking.Console.Models;

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

    public virtual decimal GetTfBalance()
    {
        return Balance;
    }

    public virtual string GetInformationAccounts()
    {
        return $"Account Number: {AccountNumber}\nName: {OwnerName}\nBalance: {Balance}\n";
    }

    public virtual void TransferReceiver(decimal jumlahTf)
    {
        if(jumlahTf < 0)
        {
            throw new ArgumentException("Jumlah harus positif");
        }

        Balance = checked(jumlahTf + Balance);
    }

    public void SendTf(decimal sendTf)
    {
        Balance -= sendTf;
    }
}
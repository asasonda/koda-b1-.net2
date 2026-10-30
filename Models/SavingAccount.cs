using Banking.Console.Interface;

namespace Banking.Console.Models;

public class SavingAccount : Account, ITransferService
{
    // private decimal ReceiverTf { get; set;}
    public SavingAccount(string accountNumber, string ownerName, decimal balance) : base(accountNumber, ownerName, balance)
    {
        // ReceiverTf = receiverTf;
    }

    public void receiverTf()
    {
        ge
    }

}
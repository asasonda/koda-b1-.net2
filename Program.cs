
using Banking.Console.Models;


Account accounts1 = new CurrentAccount("ACC001", "Andi", 5000000);
Account accounts2 = new SavingAccount("ACC002", "Budi", 3000000, 1000000);


Console.WriteLine("=============================");
Console.WriteLine("Koda Banking App");
Console.WriteLine("=============================");

List<Account> accounts = new List<Account>()
{
    accounts1, accounts2
};

foreach(Account account in accounts)
{
    System.Console.WriteLine(account.GetInformationAccounts());
}

accounts1.SendTf(1000000);
System.Console.WriteLine($"Andi: "+ accounts1.GetTfBalance());


Console.WriteLine("===============================");
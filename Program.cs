using Banking.Console.Models.Account;


Account accounts = new Account("ACC001", "Budi", 10_000);

Console.WriteLine("=============================");
Console.WriteLine("Koda Banking App");
Console.WriteLine("=============================");

Console.WriteLine(accounts.GetInformationAccounts());
Console.WriteLine("===============================");
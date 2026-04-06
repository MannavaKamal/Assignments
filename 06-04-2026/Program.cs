using System.Text.Json;

namespace _06_04_2026;

internal class Program
{
    static string path = @"c:\temp\MyTest.txt";
    static void Main(string[] args)
    {

       Account account = DeSerilize();
        if (account == null)
        {
            //For the first Run
            FirstRun();
            return;
        }
        //For more than 1 Run
        account = ExecuteMenu(account);
        Serilize(account);


    }

    static void FirstRun()
    {
        Console.WriteLine("Welcome ! Enter the Account Details to create new Account\n");
        Console.Write("Account No : ");
        int.TryParse(Console.ReadLine(), out int AccountNo);
        Console.Write("Account Holder Name : ");
        string AccName = Console.ReadLine();
        Console.Write("BankName : ");
        string BankName = Console.ReadLine();
        double balance;
        while (true)
        {
            Console.Write("Enter Opening balance (minimum 500): ");

            if (double.TryParse(Console.ReadLine(), out balance))
            {
                if (balance >= 500)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Balance must be at least 500. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }

        Account account = new(AccountNo, AccName, BankName, balance);
        Console.WriteLine("Account Created SuccessFully");
        account = ExecuteMenu(account);
        Serilize(account);

    }

    static Account ExecuteMenu(Account account)
    {
        while (true)
        {
            Console.WriteLine("What you wish to do?");
            Console.WriteLine("1.Deposit\n2.Withdraw\n3.DisplayBalance\n4.Exit\nEnter Your Choice");
            int.TryParse(Console.ReadLine(), out int menu);
            switch (menu)
            {
                case 1:
                    Console.WriteLine("Enter the Amount to Deposit");
                    double.TryParse(Console.ReadLine(), out double amount);
                    account.Deposit(amount);
                    break;
                case 2:
                    Console.WriteLine("Enter the Amount to Withdraw");
                    double.TryParse(Console.ReadLine(), out double WithDrawAmount);
                    account.WithDraw(WithDrawAmount);
                    break;
                case 3:
                    Console.WriteLine($"Balance for Account no {account.GetAccountNumber()} is {account.CheckBalance()}");
                    break;
                case 4: return account;
                default:
                    Console.WriteLine("InValid Input");
                    break;
            }
        }
    }

    static void Serilize(Account account)
    {
        Console.WriteLine(account.CheckBalance());
        string json = JsonSerializer.Serialize(account);
        File.WriteAllText(path, json);
        Console.WriteLine("Account Serilized");
    }

    static Account DeSerilize()
    {
        string json = File.ReadAllText(path);
        Console.WriteLine(json);
        if (!string.IsNullOrWhiteSpace(json))
        {
            Account? account = JsonSerializer.Deserialize<Account>(json);
            Console.WriteLine("Account content exists");
            return account;
        }
        Console.WriteLine("Account content does not exists");
        return null;

    }
}

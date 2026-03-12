using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace _13_03_2026_2;

internal class Account
{
    public string AccountNumber { get; private set; }
    public string Name { get; set; }
    public double Balance { get; private set; }
    public string AccountType { get; set; }
    public Account(string name, double balance, string accountType)
    {
        AccountNumber = GenerateAccountNumber();
        Name = name;
        Balance = balance;
        AccountType = accountType;
    }
    private string GenerateAccountNumber()
    {
        Random rand = new Random();
        return "IDBI1000" + rand.Next(1000000, 9999999);
    }

    
    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine("Amount Deposited Successfully.");
    }

    public void Withdraw(double amount)
    {
        if (Balance - amount < 500)
        {
            Console.WriteLine("Withdrawal failed. Minimum balance of 500 must be maintained.");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine("Withdrawal Successful.");
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Account Holder: " + Name);
        Console.WriteLine("Account Type: " + AccountType);
        Console.WriteLine("Balance: " + Balance);
    }

}

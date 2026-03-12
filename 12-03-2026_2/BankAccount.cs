using System;
using System.Collections.Generic;
using System.Text;

namespace _12_03_2026_2;

 class BankAccount
{
    public string AccountHolder;
    public double Balance;

    public BankAccount(string accountHolder, double balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Your Current Balance After this Deposit is {Balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Your Current Balance after withdraw = {Balance}");
        }
        else
        {
            Console.WriteLine("You Have Insufficent Balance");
        }
    }
}

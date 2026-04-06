using System;
using System.Collections.Generic;
using System.Text;

namespace _06_04_2026;

internal class Account
{
    public int _accountNo { get; set; }
    public string _accountHolderName { get; set; }
    public string _bankName { get; set; }
    public double _balance{ get; set; }

    public Account(int  _accountNo, string _accountHolderName,string  _bankName,double _balance)
    {
        
            this._accountNo = _accountNo;
            this._accountHolderName = _accountHolderName;
            this._bankName = _bankName;
            this._balance = _balance;
        
    }
    public int GetAccountNumber()
    {
        return _accountNo;
    }
    public void Deposit(double amount)
    {
        _balance = _balance + amount;
    }
    public void WithDraw(double amount)
    {
        if(_balance < amount)
        {
            Console.WriteLine("InSufficient Amount");
            return;
        }
        if(_balance - amount < 500 )
        {
            Console.WriteLine("Min Balance of Rs. 500 should be maintained");
            return;
        }
        _balance = _balance - amount;
        Console.WriteLine($"{amount} is Withdrawn form your account");
    }
    public double CheckBalance()
    {
        return _balance;
    }

}

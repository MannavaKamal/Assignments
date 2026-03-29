using System;
using System.Collections.Generic;
using System.Text;

namespace _30_03_2026;

internal class Tester : Employee
{
    public Tester(int id, string name, double basicSalary)
       : base(id, name, basicSalary) { }

    public override double CalculateSalary()
    {
        double perks = 0.3 * BasicSalary;
        return BasicSalary + perks;
    }

    public override void Display()
    {
        double total = CalculateSalary();
        Console.WriteLine($"Tester -> ID: {Id}, Name: {Name}, Monthly Salary: {total}, Annual CTC: {total * 12}");
    }
}

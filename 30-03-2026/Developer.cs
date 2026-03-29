using System;
using System.Collections.Generic;
using System.Text;

namespace _30_03_2026;

internal class Developer : Employee
{
    public Developer(int id, string name, double basicSalary)
       : base(id, name, basicSalary) { }

    public override double CalculateSalary()
    {
        double pa = 0.4 * BasicSalary;
        return BasicSalary + pa;
    }

    public override void Display()
    {
        double total = CalculateSalary();
        Console.WriteLine($"Developer -> ID: {Id}, Name: {Name}, Monthly Salary: {total}, Annual CTC: {total * 12}");
    }
}

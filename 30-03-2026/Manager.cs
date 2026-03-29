using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace _30_03_2026;

internal class Manager : Employee
{
    public Manager(int id, string name, double basicSalary)
        : base(id, name, basicSalary) { }

    public override double CalculateSalary()
    {
        double ta = 0.5 * BasicSalary;
        double da = 0.4 * BasicSalary;
        return BasicSalary + ta + da;
    }

    public override void Display()
    {
        double total = CalculateSalary();
        Console.WriteLine($"Manager -> ID: {Id}, Name: {Name}, Monthly Salary: {total}, Annual CTC: {total * 12}");
    }
}

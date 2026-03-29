using System;
using System.Collections.Generic;
using System.Text;

namespace _30_03_2026;

internal   class Employee
    {
        public int Id;
        public string Name;
        public double BasicSalary;

        public Employee(int id, string name, double basicSalary)
        {
            Id = id;
            Name = name;
            BasicSalary = basicSalary;
        }

        public virtual double CalculateSalary()
        {
            return BasicSalary;
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Basic: {BasicSalary}");
        }
    }

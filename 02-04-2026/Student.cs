using System;
using System.Collections.Generic;
using System.Text;

namespace _02_04_2026;

internal class Student
{
    internal string Name { get; set; }
    internal int Age { get; set; }
    internal int Marks { get; set; }

    public override string ToString()
    {
        return $"Name = {Name} , Age = {Age} , Marks = {Marks}";
    }

}

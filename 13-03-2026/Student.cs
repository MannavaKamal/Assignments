using System;
using System.Collections.Generic;
using System.Text;

namespace _13_03_2026;

public class Student
{
    public string Name;
    public string RollNumber;
    public double[] Marks ;

    public Student(string Name, string RollNumber, double[] Marks)
    {
        this.Name = Name;
        this.RollNumber = RollNumber;
        this.Marks = Marks;
    }

    public double CalculateAverage()
    {
        double sum = 0.0;
        foreach (double mark in Marks)
        {
            sum = sum + mark;
        }
        return sum / 5;
    }

    public void CalculateGrade(double AverageMarks)
    {
        if (AverageMarks >= 90 && AverageMarks <= 100)
        {
            Console.Write("A+");
        }
        else if (AverageMarks >= 80)
        {
            Console.Write("A");
        }
        else if (AverageMarks >= 70)
        {
            Console.Write("B");
        }
        else if (AverageMarks >= 60)
        {
            Console.Write("C");
        }
        else if (AverageMarks >= 50)
        {
            Console.Write("D");
        }
        else
        {
            Console.Write("Fail");
        }

        Console.Write(" Grade");



    }
}


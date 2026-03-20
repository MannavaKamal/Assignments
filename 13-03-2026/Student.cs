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

    public string CalculateGrade()
    {
        double AverageMarks = CalculateAverage();
        if (AverageMarks >= 90 && AverageMarks <= 100)
        {
            return ("A+");
        }
        else if (AverageMarks >= 80)
        {
            return ("A");
        }
        else if (AverageMarks >= 70)
        {
            return  ("B");
        }
        else if (AverageMarks >= 60)
        {
            return  ("C");
        }
        else if (AverageMarks >= 50)
        {
            return ("D");
        }
        else
        {
            return ("Fail");
        }

       
    }

    public void Display()
    {
        string marksarr = string.Join(", ", Marks);
        Console.WriteLine($"name =  {Name} ,\n RollNUmber = {RollNumber} ,\n Marks = {marksarr} ,\n Average Marks = {CalculateAverage() } ,\n Calculate Grade = {CalculateGrade()}");
    }


}


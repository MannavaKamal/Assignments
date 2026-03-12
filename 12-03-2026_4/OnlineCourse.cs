using System;
using System.Collections.Generic;
using System.Text;

namespace _12_03_2026_4;

internal class OnlineCourse:Course
{
    public OnlineCourse(string id, string name, int max)
        : base(id, name, max) { }

    public override void EnrollStudent()
    {
        if (enrolledStudents < maxStudents)
        {
            enrolledStudents++;
            Console.WriteLine("Student enrolled in Online Course.");
        }
        else
        {
            Console.WriteLine("Online course is full.");
        }
    }
}

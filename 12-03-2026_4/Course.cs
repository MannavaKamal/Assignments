using System;
using System.Collections.Generic;
using System.Text;

namespace _12_03_2026_4
{
    abstract class Course
    {

        protected string courseId;
        protected string courseName;
        protected int maxStudents;
        protected int enrolledStudents = 0;

        public Course(string id, string name, int max)
        {
            courseId = id;
            courseName = name;
            maxStudents = max;
        }

        public abstract void EnrollStudent();
    }
}

namespace _12_03_2026_4;

internal class Program
{
    static void Main(string[] args)
    {
        Course c1 = new OnlineCourse("C101", "Cloud Computing", 50);
        Course c2 = new InPersonCourse("C102", "Data Structures", 30);
        c1.EnrollStudent();
        c2.EnrollStudent();
    }
}

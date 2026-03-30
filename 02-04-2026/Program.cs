namespace _02_04_2026;

internal class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student{Name = "kamal" , Age = 16 , Marks = 100},
             new Student{Name = "Anish" , Age = 13 , Marks = 50},
            new Student{Name = "sai" , Age = 25 , Marks = 70},
            new Student{Name = "venket" , Age = 30 , Marks = 90}
        };
        
        Predicate<Student> markspredicate = x => x.Marks > 60;

        Predicate<Student> agePredicate = x => x.Age < 18;

        Predicate<Student> Namepredicate = x => x.Name.StartsWith('A');

        List<Student> afterPredicate ;

        if (students.Exists(markspredicate))
        {
            afterPredicate = students.FindAll(markspredicate);
            Console.WriteLine("Students with marks greater than 60");
            foreach (Student student in afterPredicate)
            {
                Console.WriteLine(student.ToString());
            }
        }
        else
        {
            Console.WriteLine("No Students Marks Greater than 60");
        }


        if (students.Exists(agePredicate))
        {
            afterPredicate = students.FindAll(agePredicate);

            Console.WriteLine("Students with Age less than 18");
            foreach (Student student in afterPredicate)
            {
                Console.WriteLine(student.ToString());
            }
        }
        else
        {
            Console.WriteLine("No Students age lessthan 18");
        }


        if (!students.Exists(Namepredicate))
        {
            Console.WriteLine("No Students Name Starts with A");
            return;
        }
        afterPredicate = students.FindAll(Namepredicate);

        Console.WriteLine("Students with Name Starts with A");
        foreach (Student student in afterPredicate)
        {
            Console.WriteLine(student.ToString());
        }


    }
}

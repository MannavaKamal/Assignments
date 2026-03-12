using System.Numerics;

namespace _13_03_2026_1;

 class Program
{
    static void Main(string[] args)
    {
        //Poc on In and Out Variables?
        float salary = OutParamDemo("kamal", -8222, out float hra, out float tax, out string category);
        Console.WriteLine($"Salary in Hand : {salary} , hra : {hra} , tax : {tax} , category : {category}");

        //How to use Intger.TryParse() poc ?
        if(int.TryParse(Console.ReadLine(), out int num))
        {
            Console.WriteLine($"Your Input Number is {num}");
        }
        else
        {
            Console.WriteLine($"You are not given the input as integer Please run program again and give only Integer as input");
        }

        //3>POC on params array  and does WriteLine() uses params array if yes show example?
        param("kamal", "mannava");
        param();




    }

    public static float OutParamDemo(in string name, float salary, out float hra, out float tax, out string category)
    {
        if (salary > 0)
        {
            // Claculate HRA
            hra = salary * 0.1f;

            // Clauclate tax
            if (salary >= 50000)
            {
                tax = salary * 0.2f;
                category = "manager";
                //Detecut hra and tax for Salary in hand
                return salary - hra - tax;
            }
            tax = salary * 0.1f;
            category = "Staff";
            //Detecut hra and tax for Salary in hand
            return salary - hra - tax;
        }
        hra = 0;
        tax = 0;
        category = "Invalid Data";
        return salary;
    }

    static void param(params string[] names)
    {
        Console.WriteLine("names : ");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

    }
}

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)

        {            
             int.TryParse(Console.ReadLine(),out int number);
            Console.WriteLine(number);
            int result = 1;
            for(int i = 1; i <= number; i++)
            {
                result = result * i;
            }
            Console.WriteLine($"the factorial of {number} is {result}");
        }
    }
}

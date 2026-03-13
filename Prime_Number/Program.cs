namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Sqrt(25));
            int.TryParse(Console.ReadLine(), out int number);
            for (int i = 2; i <= Math.Sqrt(number ); i++) {
                if (number % i == 0) {
                    
                    Console.WriteLine($"No {number} is  Not a Prime number");
                    return;
                }
            }
            Console.WriteLine($"Yes {number} is a Prime number");
        }
    }
}

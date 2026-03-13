namespace Reverse_of_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int number);
            int result = 0;
            while (number != 0) {

                int rem = number % 10;
                result = result*10 + rem;
                number = number / 10;

            }
            Console.WriteLine(result);
        }
    }
}

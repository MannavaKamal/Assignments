namespace Armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int number);
            int actNum = number , result = 0;

            while (number != 0)
            {
                int rem = number % 10;
                result = result  + rem * rem * rem;
                number = number / 10;
            }
            if (result == actNum) {
                Console.WriteLine($"Yes {actNum} is a amstrong number");
                return;
            }
            Console.WriteLine($"No {actNum} is a Not amstrong number");
        }
    }
}

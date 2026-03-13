namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int number);
            int a = 0, b = 1, c;
            Console.Write("0 , 1");
            for (int i = 0; i < number-2; i++) {
                c = a + b;
                Console.Write(" , " +c);
                a = b;
                b = c;

            }
        }
    }
}

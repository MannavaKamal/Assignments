using _12_03_2026;

namespace _12_03_2026_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("C# Programming", "Kamal", 600, true);
           Console.Write($"your book final price is {b1.CalculateDiscountedPrice()}");
        }
    }
}

namespace _12_03_2026_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ProductApp pa = new ProductApp(1,"Ice-Creem",20,5);
            ProductApp pa2 = new ProductApp(2, "Cake", 200, 10);
            Console.WriteLine( pa.ToString());
            Console.WriteLine( pa2.ToString());
        }
    }
}

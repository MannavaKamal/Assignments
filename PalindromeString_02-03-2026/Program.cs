namespace PalindromeString_02_03_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            char[] arr = inputString.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);

            if (inputString == reversed) { 
                 Console.WriteLine("Yes your string is palinprome");
                return;
            }
            Console.WriteLine("No your string not a palinprome");
        }
    }
}

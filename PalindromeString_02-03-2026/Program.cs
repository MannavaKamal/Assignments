namespace PalindromeString_02_03_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            char[] strarr = inputString.ToCharArray();
            int len = strarr.Length;
            for (int i = 0; i <len ; i++)
            {
                if (strarr[i] != strarr[len - i - 1])
                {
                    Console.WriteLine("No your string not a palinprome");
                    return;
                }
            }
            Console.WriteLine("Yes your string is palinprome");
        }
    }
}

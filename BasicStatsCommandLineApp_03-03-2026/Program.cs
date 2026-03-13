namespace BasicStatsCommandLineApp_03_03_2026
{
    internal class Program
    {
        static void Main(string[] args) // asumming all args are integers
        {
            int argsLength = args.Length; 
            int sum = 0;
            int.TryParse(args[0], out int variable);
            int minmum = variable , maximum = variable;
            for (int i = 0; i < argsLength; i++)
            {                
                int.TryParse(args[i], out  variable);
                // for sum
                sum = sum + variable;
                //for min
                if (variable < minmum)
                {
                    minmum = variable;
                }
                // for max
                if (variable > maximum) 
                { 
                    maximum = variable;
                }
            }
            Console.WriteLine(argsLength); // count
            Console.WriteLine(sum); // Sum
            Console.WriteLine(sum/argsLength); // Average
            Console.WriteLine(minmum);//minimum
            Console.WriteLine(maximum);// maximum
        }
    }
}

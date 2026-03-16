namespace _10_03_2026;

internal class Program
{
    static void Main(string[] args)
    {
       double[] fees =  AcceceptFees(new double[5]);
        Console.WriteLine("The fees with discount are as ");
        for (int i=0;i<5;i++)
        {
            Console.WriteLine($"Student {i+1}  =  {fees[i]}");
        }
    }

    static double[] AcceceptFees(double[] fees)
    {
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Enter the fees for student {i+1}");
            int.TryParse(Console.ReadLine(),out int fee);
            while(!(fee>5000 && fee < 10000))
            {
                Console.WriteLine("Error! Fees must be in the range 5000 to 10000");
                int.TryParse(Console.ReadLine(), out  fee);

            }
            if (fee > 7000)
            {
                fees[i] = fee - (fee * 0.05);
            }
            else
            {
                fees[i] = fee; 
            }
        }
        return fees;
    }
}

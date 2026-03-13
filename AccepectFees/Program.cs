namespace AccepectFees;
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] fees = new double[5];

            for (int i = 0; i < fees.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Enter fees for student {i + 1}: ");

                    if (double.TryParse(Console.ReadLine(), out double input))
                    {
                        if (input >= 5000 && input <= 10000)
                        {
                            fees[i] = input;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Fees must be between 5000 and 10000.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Enter a valid number.");
                    }
                }
            }

            double[] updatedFees = ApplyDiscount(fees);

            Console.WriteLine("\nFees after discount (if applicable):");

            for (int i = 0; i < updatedFees.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}: {updatedFees[i]}");
            }
        }
        

        static double[] ApplyDiscount(double[] fees)
        {
            for (int i = 0; i < fees.Length; i++)
            {
                if (fees[i] > 7000)
                {
                    double discount = fees[i] * 0.05;
                    fees[i] = fees[i] - discount;
                }
            }

            return fees;
        }
    }


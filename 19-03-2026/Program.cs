namespace _19_03_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalScore = 0;
            int targetScore = 20;
            Random dice = new Random();

            Console.WriteLine("Welcome to Pig Dice!");
            Console.WriteLine("Reach 20 points to win");

            while (totalScore < targetScore)
            {
                int turnTotal = 0;
                bool turnOver = false;

                Console.WriteLine("--- New Turn ---");

                while (!turnOver)
                {
                    Console.Write("Roll or Hold? (r/h): ");
                    string choice = Console.ReadLine().ToLower();

                    if (choice == "r")
                    {
                        int roll = dice.Next(1, 7);
                        Console.WriteLine($"You rolled: {roll}");

                        if (roll == 1)
                        {
                            Console.WriteLine("Rolled a 1! Turn over No points earned");
                            turnTotal = 0;
                            turnOver = true;
                        }
                        else
                        {
                            turnTotal += roll;
                            Console.WriteLine($"Turn total: {turnTotal}");
                        }
                    }
                    else if (choice == "h")
                    {
                        totalScore += turnTotal;
                        Console.WriteLine($"You held. Added {turnTotal} points.");
                        Console.WriteLine($"Total score: {totalScore}");
                        turnOver = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Enter 'r' to roll or 'h' to hold.");
                    }
                }
            }

            Console.WriteLine("Congratulations! You reached 20 points and won");
            Console.ReadLine();
        }
    }
}

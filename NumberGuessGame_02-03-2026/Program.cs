namespace NumberGuessGame_02_03_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Boolean exitStatus = false;
            while (true)
            {
                int number = rand.Next(1, 101); // genaretes the random number 1 to 100
                Console.WriteLine($"Number that generated is {number}");
                while (true)
                {
                    Console.WriteLine("Enter the number to Guess");
                    if (int.TryParse(Console.ReadLine(), out int guessNumber))
                    {
                        Console.WriteLine($"you entered number  = {guessNumber}");
                        if (guessNumber == number)
                        {
                            Console.WriteLine("Yes your Guess is Correct ... Enter 1 if you want to paly again or if you want to exit Enter any other number");
                            if (int.TryParse(Console.ReadLine(), out int playAgain))
                            {

                                if (playAgain == 1)
                                {
                                    break;
                                }
                                else
                                {
                                    exitStatus = true;
                                    break;
                                }
                            }
                        }
                        else if (guessNumber > number)
                        {
                            Console.WriteLine("Too High Number");
                        }
                        else
                        {
                            Console.WriteLine("Too Low Number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter only numbers");
                    }
                }
                if(exitStatus) 
                {
                    break;
                }
                else
                {
                    continue;
                }

            }
        }
    }
}

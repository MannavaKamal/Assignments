namespace _18_04_2026;

internal class Program
{
    static void Main(string[] args)
    {
        TicTacToeFacade game = new TicTacToeFacade();

        Console.WriteLine("Welcome to Tic Tac Toe!");
        game.DisplayBoard();
        Console.WriteLine("Player 1 starts (X)");

        while (true)
        {
            Console.Write("\nEnter row (0-2): ");
            int row;
            if (!int.TryParse(Console.ReadLine(), out row) || row < 0 || row > 2)
            {
                Console.WriteLine("Invalid row. Try again.");
                continue;
            }

            Console.Write("Enter column (0-2): ");
            int col;
            if (!int.TryParse(Console.ReadLine(), out col) || col < 0 || col > 2)
            {
                Console.WriteLine("Invalid column. Try again.");
                continue;
            }

            // Play move
            game.PlayMove(row, col);

           
            if (game.IsGameOver())
            {
                Console.Write("\nDo you want to play again? (y/n): ");
                string choice = Console.ReadLine().ToLower();

                if (choice == "y")
                {
                    game.ResetGame();
                    continue;
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
            }
        }
    }
}

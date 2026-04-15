using System;
using System.Collections.Generic;
using System.Text;

namespace _18_04_2026;

public class TicTacToeFacade
{
    private Board board;
    private GameLogic logic;
    private Player player1;
    private Player player2;
    private Player currentPlayer;
    private bool gameOver;

    public TicTacToeFacade()
    {
        board = new Board();
        logic = new GameLogic();
        player1 = new Player("Player 1", 'X');
        player2 = new Player("Player 2", 'O');
        currentPlayer = player1;
        gameOver = false;
    }

    public void PlayMove(int row, int col)
    {
        if (gameOver)
        {
            Console.WriteLine("Game is over. Reset to play again.");
            return;
        }

        if (!board.PlaceMark(row, col, currentPlayer.Symbol))
        {
            Console.WriteLine("Invalid move. Try again.");
            return;
        }

        board.Display();

        if (logic.CheckWinner(board.GetGrid(), currentPlayer.Symbol))
        {
            Console.WriteLine($"{currentPlayer.Name} wins!");
            gameOver = true;
            return;
        }

        if (logic.IsDraw(board.GetGrid()))
        {
            Console.WriteLine("It's a draw!");
            gameOver = true;
            return;
        }

        SwitchPlayer();
        Console.WriteLine($"{currentPlayer.Name}'s turn ({currentPlayer.Symbol})");
    }

    private void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == player1) ? player2 : player1;
    }

    public void ResetGame()
    {
        board.Reset();
        currentPlayer = player1;
        gameOver = false;
        Console.WriteLine("Game reset!");
        board.Display();
        Console.WriteLine($"{currentPlayer.Name}'s turn ({currentPlayer.Symbol})");
    }

    public void DisplayBoard()
    {
        board.Display();
    }

    public bool IsGameOver()
    {
        return gameOver;
    }
}

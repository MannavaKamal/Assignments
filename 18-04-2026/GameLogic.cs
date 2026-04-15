using System;
using System.Collections.Generic;
using System.Text;

namespace _18_04_2026;

public class GameLogic
{
    public bool CheckWinner(char[,] grid, char symbol)
    {
        // Rows & Columns
        for (int i = 0; i < 3; i++)
        {
            if ((grid[i, 0] == symbol && grid[i, 1] == symbol && grid[i, 2] == symbol) ||
                (grid[0, i] == symbol && grid[1, i] == symbol && grid[2, i] == symbol))
                return true;
        }

        // Diagonals
        if ((grid[0, 0] == symbol && grid[1, 1] == symbol && grid[2, 2] == symbol) ||
            (grid[0, 2] == symbol && grid[1, 1] == symbol && grid[2, 0] == symbol))
            return true;

        return false;
    }

    public bool IsDraw(char[,] grid)
    {
        foreach (var cell in grid)
        {
            if (cell == ' ')
                return false;
        }
        return true;
    }
}
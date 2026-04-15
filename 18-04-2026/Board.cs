using System;
using System.Collections.Generic;
using System.Text;

namespace _18_04_2026;

public class Board
{
    private char[,] grid = new char[3, 3];

    public Board()
    {
        Reset();
    }

    public bool PlaceMark(int row, int col, char symbol)
    {
        if (grid[row, col] == ' ')
        {
            grid[row, col] = symbol;
            return true;
        }
        return false;
    }

    public char[,] GetGrid()
    {
        return grid;
    }

    public void Reset()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                grid[i, j] = ' ';
    }

    public void Display()
    {
        Console.WriteLine("\nBoard:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($" {grid[i, 0]} | {grid[i, 1]} | {grid[i, 2]} ");
            if (i < 2) Console.WriteLine("---+---+---");
        }
    }
}

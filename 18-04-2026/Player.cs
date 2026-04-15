using System;
using System.Collections.Generic;
using System.Text;

namespace _18_04_2026;

public class Player
{
    public string Name { get; }
    public char Symbol { get; }

    public Player(string name, char symbol)
    {
        Name = name;
        Symbol = symbol;
    }
}

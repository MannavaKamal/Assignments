namespace _12_03_2026;

internal class Program
{
    static void Main(string[] args)
    {
        if (Enum.TryParse(Console.ReadLine(), out Planet planet))
        {
            Console.WriteLine(GetGravity(planet));
        }
        else
        {
            Console.WriteLine("Enter the valid Planet");
        }
    }

    static double GetGravity(Planet planet)
    {
        switch (planet)
        {
            case Planet.MERCURY: return 0.38;
            case Planet.VENUS: return 0.91;
            case Planet.EARTH: return 1.0;
            case Planet.MARS: return 0.38;
            case Planet.JUPITER: return 2.34;
            case Planet.SATURN: return 1.06;
            case Planet.URANUS: return 0.92;
            case Planet.NEPTUNE: return 1.19;
            default: return 1.0;
        }
    }
}

enum Planet
{
    MERCURY,
    VENUS,
    EARTH,
    MARS,
    JUPITER,
    SATURN,
    URANUS,
    NEPTUNE
}
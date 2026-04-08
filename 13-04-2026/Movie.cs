using System;
using System.Collections.Generic;
using System.Text;

namespace _13_04_2026;

internal class Movie
{
    public int Id;
    public string Name;
    public int YearOfRelease;
    public string Genre;

    public Movie(int id, string name, int yearOfRelease, string genre)
    {
        Id = id;
        Name = name;
        YearOfRelease = yearOfRelease;
        Genre = genre;
    }

    public void Display()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Year: {YearOfRelease}");
        Console.WriteLine($"Genre: {Genre}");
    }
}

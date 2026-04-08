namespace _13_04_2026;

internal class Program
{
    static void Main(string[] args)
    {
        List<Movie> movies = new List<Movie>();
        Console.WriteLine("Welcome to movie store developed by : Kamal Mannava");
        while (true)
        {
            Console.WriteLine("1. Add new Movie");
            Console.WriteLine("2. Display All Movies");
            Console.WriteLine("3. Find Movie by ID");
            Console.WriteLine("4. Remove Movie by ID");
            Console.WriteLine("5. Clear All Movies");
            Console.WriteLine("6. Exit");
            int.TryParse(Console.ReadLine(), out int choice);
            switch (choice)
            {
                case 1:
                    Add(movies);
                    break;
                case 2:
                    Display(movies); break;
                case 3:
                    Console.WriteLine("Enter the Movie Id to find");
                    int.TryParse(Console.ReadLine(), out int movieId);
                    FindMovie(movies, movieId);
                    break;
                case 4:
                    Console.WriteLine("Enter the Movie Id to Remove");
                    int.TryParse(Console.ReadLine(), out int movieId1);
                    RemoveMovie(movies, movieId1);
                    break;
                case 5:
                    movies.Clear();
                    Console.WriteLine("All Movies are cleared");
                    break;
                case 6:
                    Console.WriteLine("Thankyou for choosing our App Visist Again...");
                    return;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
        
    }

    static void Add(List<Movie> movies)
    {
        if (movies.Count == 5) { Console.WriteLine("You Cannot add more then 5 Movies"); return; };

        Console.WriteLine($"Add Movie number : {movies.Count + 1}");
        Console.Write("Enter Movie Id: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Movie Name: ");
        String name = Console.ReadLine();

        Console.Write("Enter Year Of Release: ");
        int year = int.Parse(Console.ReadLine());

        Console.Write("Enter Genre: ");
        string genre = Console.ReadLine();

        Movie movie = new Movie(id,name,year,genre);

        movies.Add(movie);
        Console.WriteLine("movie added successfully");
    }

    static void Display(List<Movie> movies)
    {
        if (movies.Count == 0)
        {
            Console.WriteLine("No Movies to Display");
            return;
        }
        foreach (Movie movie in movies)
        {
            movie.Display();
        }
    }

    static int FindMovie(List<Movie> movies,int movieId)
    {
        int index = -1;
        foreach(Movie movie in movies)
        {
            index++;
            if(movie.Id == movieId)
            {
                Console.WriteLine($"Movie with {movieId} is found");
                movie.Display();
                return index;
            }
        }
        Console.WriteLine($"Movie with {movieId} is not found");
        return index;
    }

    static void RemoveMovie(List<Movie> movies,int movieId)
    {
        int index =  FindMovie(movies,movieId);
        if (index == -1)
            return;        
        movies.RemoveAt(index);
        Console.WriteLine($"Movie with {movieId} is removed");
    }
}

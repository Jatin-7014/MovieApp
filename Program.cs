using MovieStoreApp.Models;
namespace MovieStoreApp
{
    internal class Program
    {
        static List<Movie> movies=new List<Movie>();
        static void Main(string[] args)
        {
            DisplayMenu();
        }

        static void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("==========Welcome to movie store developed by: Jatin=========\n");
                Console.WriteLine("1.Add New Movie\n" +
                    "2.Display All Movies\n" +
                    "3.Find Movie By Id\n" +
                    "4.Remove Movie By Id\n" +
                    "5.Clear All Movies\n" +
                    "6.Exit");
                int choice=Convert.ToInt32(Console.ReadLine());
                DoTask(choice);
            } 
        }
        static void DoTask(int choice)
        {
            switch(choice)
            {
                case 1:
                    AddNewMovies();
                    break;

                case 2:
                    DisplayMovies();
                    break;

                case 3:
                    Movie findMovie=FindMovieById();
                    if (findMovie != null)
                        Console.WriteLine(findMovie);
                    else
                        Console.WriteLine("Movie not found...");
                    break;

                case 4:
                    RemoveMovie();
                    break;

                case 5:
                    if (movies.Count == 0)
                        Console.WriteLine("Movies List is Empty....\nNothing to Clear");
                    else
                        movies.Clear();
                    break;

                case 6:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please provide a valid input...");
                    break;
            }
        }
        static void AddNewMovies()
        {
            if (movies.Count < 5)
            {
                Console.WriteLine("Enter Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Year Of Release: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Genre: ");
                string genre = Console.ReadLine();
                Movie movie = Movie.AddNewMovie(id, name, year, genre);
                Console.WriteLine("New Movie Added Successfully");
                movies.Add(movie);
            }
            else
            {
                Console.WriteLine("Memory space is full can't add another movie...");
            }

        }

        static void DisplayMovies()
        {
            if (movies.Count == 0)
                Console.WriteLine("Movies List is empty...");
            else
                movies.ForEach(item => Console.WriteLine(item));
        }

        static Movie FindMovieById()
        {
            Movie findMovie = null;
            Console.WriteLine("Enter Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            findMovie=movies.Where(item=>item.Id==id).FirstOrDefault();
            return findMovie;
        }

        static void RemoveMovie()
        {
            Movie findMovie = FindMovieById();
            if (findMovie != null)
            {
                movies.Remove(findMovie);
                Console.WriteLine("Movie Removed Successfully....");
            }
            else
                Console.WriteLine("Movie not found.....");
        }
    }
}

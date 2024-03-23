using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatreManagementSystem
{
    internal class ManageMoviesMenu
    {
        // list for storing movies 
        public static List<Movie> movies = new List<Movie>();

        // displayes the menu for managing movies 
        public static void DisplayMovieMenu()
        {
            Console.WriteLine("Manage Movies:");
            Console.WriteLine("1. Add a new movie");
            Console.WriteLine("2. Remove a movie");
            Console.WriteLine("3. Update movie details");
            Console.WriteLine("4. View all movies");
            Console.WriteLine("5. Back to the Main Menu");
            Console.WriteLine();
            Console.Write("Please enter your choice: ");
        }

        // adds a new movie
        public static void AddNewMovie()
        {
            Console.WriteLine("Enter the movie Id:");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid input. Please enter a valid release id.");
            }

            Console.WriteLine("Enter the title of the movie:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter the genre of the movie:");
            string genre = Console.ReadLine();

            Console.WriteLine("Enter the release year of the movie:");
            int releaseYear;
            while (!int.TryParse(Console.ReadLine(), out releaseYear))
            {
                Console.WriteLine("Invalid input. Please enter a valid release year.");
            }

            Console.WriteLine("Enter the duration of the movie (in minutes):");
            int duration;
            while (!int.TryParse(Console.ReadLine(), out duration))
            {
                Console.WriteLine("Invalid input. Please enter a valid duration.");
            }

            // Pass Movie constructor
            Movie newMovie = new Movie(title, genre, releaseYear, duration, id);

            movies.Add(newMovie);
            Console.WriteLine("Movie added successfully.");
        }

        // removes movie 
        public static void RemoveMovie()
        {
            Console.WriteLine("Enter the title of the movie to remove:");
            string title = Console.ReadLine();

            Movie movieToRemove = movies.Find(movie => movie.Title == title);
            if (movieToRemove != null)
            {
                movies.Remove(movieToRemove);
                Console.WriteLine($"Movie '{title}' removed successfully.");
            }
            else
            {
                Console.WriteLine($"Movie '{title}' not found.");
            }
        }
        
        // updates movie info
        public static void UpdateMovieDetails()
        {
            Console.WriteLine("Enter the title of the movie to update:");
            string titleToUpdate = Console.ReadLine();

            Movie movieToUpdate = movies.Find(movie => movie.Title == titleToUpdate);
            if (movieToUpdate != null)
            {
                Console.WriteLine("Enter the new title of the movie:");
                string newTitle = Console.ReadLine();
                movieToUpdate.Title = newTitle;

                Console.WriteLine("Enter the new genre of the movie:");
                string newGenre = Console.ReadLine();
                movieToUpdate.Genre = newGenre;

                Console.WriteLine("Enter the new release year of the movie:");
                int newReleaseYear;
                while (!int.TryParse(Console.ReadLine(), out newReleaseYear))
                {
                    Console.WriteLine("Invalid input. Please enter a valid release year.");
                }
                movieToUpdate.ReleaseYear = newReleaseYear;

                Console.WriteLine("Enter the new duration of the movie (in minutes):");
                int newDuration;
                while (!int.TryParse(Console.ReadLine(), out newDuration))
                {
                    Console.WriteLine("Invalid input. Please enter a valid duration.");
                }
                movieToUpdate.Duration = newDuration;

                Console.WriteLine("Movie details updated successfully.");
            }
            else
            {
                Console.WriteLine($"Movie '{titleToUpdate}' not found.");
            }
        }

        // view/show all movies 
        public static void ViewAllMovies()
        {
            if (movies.Count == 0)
            {
                Console.WriteLine("No movies available.");
            }
            else
            {
                Console.WriteLine("All Movies:");
                foreach (var movie in movies)
                {
                    Console.WriteLine(movie);
                }
            }
        }

    }

}

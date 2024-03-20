using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatreManagementSystem
{
    internal class ManageMovies
    {
        public string Title { get; set; }
        private List<Movie> movies;

        public ManageMovies()
        {
            movies = new List<Movie>();
        }

        public void AddMovie(string title, string genre, int releaseYear, int duration)
        {
            int id = movies.Count + 1;

            Movie movie = new Movie(title, genre, releaseYear, duration)
            {
                Id = id,
                Title = title,
                Genre = genre,
                ReleaseYear = releaseYear,
                Duration = duration
            };

            movies.Add(movie);

            Console.WriteLine("Movie added successfully");
        }

        public void RemoveMovie(string title) 
        {
            Movie removeMovie = null;
            bool movieIsFound = false;

            foreach (var movie in movies)
            {
                if (movie.Title == title)
                {
                    removeMovie = movie;
                    movieIsFound = true;
                    break;
                }
            }

            if (movieIsFound)
            {
                movies.Remove(removeMovie);
                Console.WriteLine($"Movie {title} removed successfully");
            }

            else
            {
                Console.WriteLine($"Movie {title} cannot be found");
            }
        }

        public void UpdateMovie(string title, string updatedTitle, string genre, string updatedGenre, int releaseYear, int updatedReleaseYear, int duration, int updatedDuration)
        {
            Movie updateMovie = null;
            bool movieIsFound = false;

            foreach (var movie in movies)
            {
                if (movie.Title == title)
                {
                    updateMovie = movie;
                    movieIsFound = true;
                    break;
                }
            }

            if (movieIsFound)
            {
                updateMovie.Title = updatedTitle;
                updateMovie.Genre = updatedGenre;
                updateMovie.ReleaseYear = updatedReleaseYear;
                updateMovie.Duration = updatedDuration;

                Console.WriteLine($"Movie {title} updated successfully");
            }

            else
            {
                Console.WriteLine($"Movie {title} cannot be found");
            }

        }

        public void PrintMovie()
        {
            Console.WriteLine($"Movies in {Title}: ");
            foreach (var movie in movies)
            {
                Console.WriteLine(movie.ToString());
            }
        }

        private Movie GetMovieTitle(string title)
        {
            foreach (var movie in movies)
            {
                if (movie.Title == title)
                {
                    return movie;
                }
            }
            return null;
        }
    }
}

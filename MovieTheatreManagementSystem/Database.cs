using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MovieTheatreManagementSystem
{
    internal class Database
    {
        public static void SearchMoviesInSpecificTheater(List<Venue> venues)
        {
            Console.WriteLine("Search for Movies in a Specific Theater");
            Console.WriteLine("Enter the ID of the Venue:");

            int venueId;
            if (!int.TryParse(Console.ReadLine(), out venueId))
            {
                Console.WriteLine("Invalid input. Please enter a valid venue ID.");
                return;
            }

            Venue selectedVenue = venues.FirstOrDefault(v => v.Id == venueId);

            if (selectedVenue == null)
            {
                Console.WriteLine("Venue not found.");
                return;
            }

            string filePath = @"C:\Users\Admin\Documents\MovieTheatre\MovieTheatreManagementSystem\search.txt";

            List<string> fileContents = new List<string>();

            fileContents.Add($"List of Movies in {selectedVenue.Name} Venue");

            List<Theater> matchingTheaters = ManageTheaterMenu.theaters.Where(theater => theater.IdForVenue == selectedVenue.Id).ToList();
            if (matchingTheaters == null)
            {
                Console.WriteLine("Theatre not found.");
                return;
            }

            int i = 0;
            int movieCount = 0; // This acts as a counter for movies added to the current theater
            foreach (Theater theater in matchingTheaters)
            {
                fileContents.Add($"{i}. The {theater.Name} ({theater.Type}):");
                fileContents.Add("Id  Title        Genre       Release Year   Duration (mins)");
                fileContents.Add("---------------------------------------------------------------------------");

                foreach (Movie movie in ManageMoviesMenu.movies)
                {
                    if (movieCount >= 2)
                    {
                        movieCount = 0;
                        break;
                    }

                    fileContents.Add($"{movie.Id} {movie}");
                    movieCount++;
                }
                i++;
            }

            try
            {
                File.WriteAllLines(filePath, fileContents);
                string[] read = File.ReadAllLines(filePath);
                foreach (string line in read)
                {
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (IOException)
            {
                Console.WriteLine("error occurred while reading file.");
            }

            Console.WriteLine($"Results saved to file: Search.txt");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Menu.MainMenu();
        }
        
    }
}

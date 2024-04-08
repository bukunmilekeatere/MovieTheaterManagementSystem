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
            // determines if input is an int
            if (!int.TryParse(Console.ReadLine(), out venueId))
            {
                Console.WriteLine("Invalid input. Please enter a valid venue ID.");
                return;
            }

            // finds inputed id in the stored id from the venue class
            Venue selectedVenue = venues.Find(v => v.Id == venueId);

            // if venue not found in venue class this message prints
            if (selectedVenue == null)
            {
                Console.WriteLine("Venue not found.");
                return;
            }

            // declares txt file
            string filePath = @"C:\Users\Admin\Documents\MovieTheatre\MovieTheatreManagementSystem\search.txt";
            
            // stores contents that is going to being added into the txt file
            List<string> fileContents = new List<string>();

            // adds to the list
            fileContents.Add($"List of Movies in {selectedVenue.Name} Venue");

            // finds the theatres in the venue id for theatre class that match an id in the venue class
            List<Theater> matchingTheaters = ManageTheaterMenu.theaters.Find(theater => theater.IdForVenue == selectedVenue.Id).ToList();

            // if no id match comes up of where theatre is stored, this prints
            if (matchingTheaters == null)
            {
                Console.WriteLine("Theatre not found.");
                return;
            }

            int i = 0;
            int movieCount = 0; // This acts as a counter for movies added to the current theater

            // declares the thatres found in the inputed venue id
            foreach (Theater theater in matchingTheaters)
            {
                // adds information to list
                fileContents.Add($"{i}. The {theater.Name} ({theater.Type}):");
                fileContents.Add("Id  Title        Genre       Release Year   Duration (mins)");
                fileContents.Add("---------------------------------------------------------------------------");

                //  finds movies stored in the thatres from the movie list
                foreach (Movie movie in ManageMoviesMenu.movies)
                {
                    // makes sure only two movies are stored in the theatre at a time
                    if (movieCount >= 2)
                    {
                        movieCount = 0;
                        break;
                    }

                    // adds to file
                    fileContents.Add($"{movie.Id} {movie}");
                    movieCount++;
                }
                i++;
            }

            try
            {
                // writes contents stored in the list into the txt file
                File.WriteAllLines(filePath, fileContents);
                string[] read = File.ReadAllLines(filePath);

                // prints contents in the txt file
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

            // takes an random key as an input for the main.menu function to run
            Console.ReadKey();
            Menu.MainMenu();
        }
        
    }
}

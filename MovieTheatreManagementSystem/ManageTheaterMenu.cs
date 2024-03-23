using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MovieTheatreManagementSystem.Theater;

namespace MovieTheatreManagementSystem
{
    internal class ManageTheaterMenu
    {
        // list for storing the theaters 
        public static List<Theater> theaters = new List<Theater>();

        public static void DisplayTheaterMenu()
        {
            Console.WriteLine("Manage Theaters:");
            Console.WriteLine("1. Add a new Movie");
            Console.WriteLine("2. Remove a Movie");
            Console.WriteLine("3. Update theater details");
            Console.WriteLine("4. View all movies in a Theatre");
            Console.WriteLine("5. Back to the Main Menu");
            Console.WriteLine();
            Console.Write("Please enter your choice: ");
        }

        // adds a new theater
        public static void AddNewTheater(int venueId, string theaterName, string theaterType)
        {
            Console.WriteLine("Enter the ID of the venue where you want to add the theater: ");
            int idForVenue;
            while (!int.TryParse(Console.ReadLine(), out idForVenue))
            {
                Console.WriteLine("Invalid input. Please enter a valid id for venue.");
            }
            //  to find venue with id 
            Venue matchedId = ManageVenueMenu.venues.Find(venues => venues.Id == idForVenue);
            if (matchedId == null)
            {
                Console.WriteLine("Id not found");
            }
            else
            {
                Console.WriteLine("Enter the name of the new theater: ");
            }
            string name = Console.ReadLine();

            Console.WriteLine("Enter the type of the new theater (regular, IMAX, DBOX, FULL RECLINER):");
            string type = Console.ReadLine();
            while (type != "IMAX" && type != "DBOX" && type != "regular" && type != "FULL RECLINER")
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Enter the type of the new theater (regular, IMAX, DBOX, FULL RECLINER):");
                type = Console.ReadLine();
            }

            // theater object
            Theater newTheater = new Theater(idForVenue, name, type);

            theaters.Add(newTheater);
            Console.WriteLine($"Theater added successfully to venue ID {idForVenue}.");
        }


        // removing a theater
        public static void RemoveTheater()
        {
            Console.WriteLine("Enter the ID of the venue where you want to remove the theater from: ");
            int idForVenue = int.Parse(Console.ReadLine());

            Theater venueToFind = theaters.Find(theater => theater.IdForVenue == idForVenue);
            if(venueToFind == null)
            {
                Console.WriteLine($"Venue {idForVenue} not found.");
            }
            else
            {
                Console.WriteLine("Enter the name of the theater you want to remove: ");
                string name = Console.ReadLine();

                Theater theaterToRemove = theaters.Find(theater => theater.Name == name);

                if (theaterToRemove != null)
                {
                    theaters.Remove(theaterToRemove);
                    Console.WriteLine($"Theater '{name}' removed successfully.");
                }
                else
                {
                    Console.WriteLine($"Theater '{name}' not found.");
                }
            }         
        }

        // updating theater info
        public static void UpdateTheaterDetails()
        {
            Console.WriteLine("Enter the ID of the venue where you want to update the theater: ");
            int idToUpdate = int.Parse(Console.ReadLine());

            Theater theaterToUpdate = theaters.Find(theater => theater.IdForVenue == idToUpdate);
            if (theaterToUpdate != null)
            {
                Console.WriteLine("Enter the new name of the theater:");
                string newName = Console.ReadLine();
                theaterToUpdate.Name = newName;

                Console.WriteLine("Enter the new type of the theater:");
                string newType = Console.ReadLine();
                theaterToUpdate.Type = newType;

                Console.WriteLine("Theatre updates successfully");
            }
            else
            {
                Console.WriteLine($"Movie '{theaterToUpdate}' not found.");
            }
        }
        // view/show all theaters
        public static void ViewAllTheaters()
        {
            if (theaters.Count == 0)
            {
                Console.WriteLine("No theaters available.");
            }
            else
            {
                Console.WriteLine("All Theaters:");
                foreach (var theater in theaters)
                {
                    Console.WriteLine(theater);
                }
            }
        }


    }
}


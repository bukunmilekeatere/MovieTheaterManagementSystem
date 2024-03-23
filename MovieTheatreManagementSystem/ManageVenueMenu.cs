using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MovieTheatreManagementSystem.Theater;

namespace MovieTheatreManagementSystem
{
    internal class ManageVenueMenu
    {
        public static List<Venue> venues = new List<Venue>();
        public static void DisplayVenueMenu()
        {
            Console.WriteLine("Manage Venues:");
            Console.WriteLine("1. Add a new venue");
            Console.WriteLine("2. Remove a venue");
            Console.WriteLine("3. Update venue details");
            Console.WriteLine("4. Add a new Theatre");
            Console.WriteLine("5. Remove a Theatre");
            Console.WriteLine("6. View all venues");
            Console.WriteLine("7.Back to the Main Menu");
            Console.WriteLine();
            Console.Write("Please enter your choice: ");
        }
        public static void AddVenue()
        {
            Console.WriteLine("Enter the ID of the venue: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid input. Please enter a valid id for venue.");
            }

            Console.WriteLine("Enter the name of the new venue: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the venue ID: ");
            int venueId;

            while (!int.TryParse(Console.ReadLine(), out venueId))
            {
                Console.WriteLine("Invalid input. Please enter a valid venue ID.");
            }

            Venue newVenue = new Venue(id, name, venueId);
            venues.Add(newVenue);
            Console.WriteLine($"Venue added successfully");
        }

        public static void AddNewTheaterToVenue()
        {
            Console.WriteLine("Enter the ID of the venue where you want to add a theater:");
            int venueId;
            while (!int.TryParse(Console.ReadLine(), out venueId))
            {
                Console.WriteLine("Invalid input. Please enter a valid venue ID.");
            }
            // find the vneu based on entered venue
            Venue venue = venues.Find(v => v.Id == venueId);
            if (venue != null)
            {
                Console.WriteLine("Enter the name of the new theater:");
                string theaterName = Console.ReadLine();

                Console.WriteLine("Enter the type of the new theater (regular, IMAX, DBOX, FULL RECLINER):");
                string theaterType = Console.ReadLine();
                // theater object
                Theater newTheater;
                switch (theaterType.ToUpper())
                {
                    case "IMAX":
                        newTheater = new IMAX(theaterName);
                        break;
                    case "DBOX":
                        newTheater = new DBOX(theaterName);
                        break;
                    case "FULL RECLINER":
                        newTheater = new FullRecliner(theaterName);
                        break;
                    default:
                        newTheater = new Theater(theaterName);
                        break;
                }

                ManageTheaterMenu.AddNewTheater(venueId, theaterName, theaterType);
                Console.WriteLine($"A new Theater was added to the Venue {venueId}.");
            }
            else
            {
                Console.WriteLine($"Venue with ID {venueId} not found.");
            }
        }

        public static void RemoveVenue()
        {
            Console.WriteLine("Enter the ID of the venue where you want to remove: ");
            int id = int.Parse(Console.ReadLine());
            // find venue removed based on Id
            Venue venueId = venues.Find(venue => venue.Id == id);

            Console.WriteLine("Enter the name of the venue you want to remove: ");
            string name = Console.ReadLine();

            Venue venueToRemove = venues.Find(venue => venue.Name == name);

            if (venueToRemove != null)
            {
                venues.Remove(venueToRemove);
                Console.WriteLine($"Venue '{name}' removed successfully.");
            }
            else
            {
                Console.WriteLine($"Venue '{name}' not found.");
            }
        }
        public static void UpdateVenue()
        {
            Console.WriteLine("Enter the ID of the venue you want to update: ");
            int idUpdate = int.Parse(Console.ReadLine());

            Venue VenueUpdate = venues.Find(venue => venue.Id == idUpdate);
            if (VenueUpdate != null)
            {
                Console.WriteLine("Enter the new name for Venue:");
                string newName = Console.ReadLine();
                VenueUpdate.Name = newName;
                Console.WriteLine("Venue updated successfully");
            }
            else
            {
                Console.WriteLine($"Venue '{VenueUpdate}' not found.");
            }
        }
        public static void ViewAllVenues()
        {
            if (venues.Count == 0)
            {
                Console.WriteLine("No venues available.");
            }
            else
            {
                Console.WriteLine("All Venues:");
                foreach (var location in venues)
                {
                    Console.WriteLine(location);
                }
            }
        }
    }
}

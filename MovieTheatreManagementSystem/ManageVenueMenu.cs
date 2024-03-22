using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("6. View all Theatres");
            Console.WriteLine("7. View all venues");
            Console.WriteLine("8.Back to the Main Menu");
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

            Venue newVenue = new Venue(id, name);

            venues.Add(newVenue);
            Console.WriteLine($"Venue added successfully");
        }


        public static void RemoveVenue()
        {
            Console.WriteLine("Enter the ID of the venue where you want to remove: ");
            int id = int.Parse(Console.ReadLine());

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

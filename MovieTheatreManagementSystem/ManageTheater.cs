using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatreManagementSystem
{
    internal class ManageTheater
    {
        private List<Theater> theaters;

        // initializes the list of theaters
        public ManageTheater()
        {
            theaters = new List<Theater>();
        }

        // adds new theater
        public void AddTheater(int idForVenue, string name, string type)
        {
            int id = theaters.Count + 1;

            Theater theater = new Theater(idForVenue, name, type)
            {
                IdForVenue = id,
                Name = name,
                Type = type,
            };

            theaters.Add(theater);

            Console.WriteLine($"Theater '{name}' added successfully.");

        }

        // removes theater
        public void RemoveTheater(string name)
        {
            Theater removeTheater = null;
            bool theaterIsFound = false;

            foreach (var theater in theaters)
            {
                if (theater.Name == name)
                {
                    removeTheater = theater;
                    theaterIsFound |= true;
                    break;
                }
            }

            if (theaterIsFound)
            {
                theaters.Remove(removeTheater);
                Console.WriteLine($"Theater {name} removed successfully");
            }

            else
            {
                Console.WriteLine($"Theater {name} cannot be found");
            }
        }

        // updates theater info
        public void UpdateTheater(string name, string updatedName, string type, string updatedType)
        {
            Theater updateTheater = null;
            bool theaterIsFound = false;

            foreach (var theater in theaters)
            {
                if (theater.Name == name)
                {
                    updateTheater = theater;
                    theaterIsFound = true;
                    break;
                }
            }

            if (theaterIsFound)
            {
                updateTheater.Name = updatedName;
                updateTheater.Name = updatedName;

                Console.WriteLine($"Movie {name} updated successfully");
            }

            else
            {
                Console.WriteLine($"Movie {name} cannot be found");
            }
        }
    }
}

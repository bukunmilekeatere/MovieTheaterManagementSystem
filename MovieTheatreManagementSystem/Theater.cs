using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatreManagementSystem
{
    internal class Theater
    {
        public int IdForVenue { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double TicketPrice { get; set; }
        public int NumberOfSeats { get; set; }

        // constructor for the theater class 
        public Theater(string name)
        {
            Name = name;
        }

        // list for the movies in theater
        public List<Movie> Movies { get; set; }

        // constructor for the theater class
        public Theater(int idForVenue, string name, string type)
        {

            IdForVenue = idForVenue;
            Name = name;
            Type = type;
            Movies = new List<Movie>();
        }

        // override tostring method to show info for theater
        public override string ToString()
        {
            return $"{IdForVenue}\t{Name}\t{Type}\t{TicketPrice} \t {NumberOfSeats}";
        }
        public class IMAX : Theater
        {
            public IMAX(string name) : base(name)
            {
                TicketPrice = 15; // Example for IMAX 
                NumberOfSeats = 100; // Example number of seats
            }
        }

        public class DBOX : Theater
        {
            public DBOX(string name) : base(name)
            {
                TicketPrice = 20; // Example ticket for DBOX 
                NumberOfSeats = 50; // Example number seats for DBOX
            }
        }

        public class FullRecliner : Theater
        {
            public FullRecliner(string name) : base(name)
            {
                TicketPrice = 25; // Example ticket price FullRecliner 
                NumberOfSeats = 30; // Example number of seat FullRecliner 
            }
        }
    }
}

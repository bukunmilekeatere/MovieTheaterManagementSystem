using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatreManagementSystem
{
    internal class Venue
    {
        // calling all our variables 
        public int Id { get; set; }
        public string Name { get; set; }
        public int VenueId { get; set; }
        public List<Theater> Theaters { get; set; }

        // constructor for the venue class
        public Venue(int id, string name, int venueId)
        {
            Id = id;
            Name = name;
            Theaters = new List<Theater>();
            this.VenueId = venueId;
        }

        // override tostring method to show the info for venue
        public override string ToString()
        {
            return $"{Id}\t{Name}\t {VenueId}\t";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatreManagementSystem
{
    internal class Venue
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Venue(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t";
        }
    }
}

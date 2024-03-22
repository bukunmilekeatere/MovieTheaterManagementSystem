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

        public List<Movie> Movies { get; set; }
        public Theater(int idForVenue, string name, string type)
        {
            IdForVenue = idForVenue;
            Name = name;
            Type = type;
            Movies = new List<Movie>();
        }
     
        public override string ToString()
        {
            return $"{IdForVenue}\t{Name}\t{Type}";
        }
    }
}

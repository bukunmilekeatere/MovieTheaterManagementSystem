using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatreManagementSystem
{
    internal class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public int Duration { get; set; }

        public Movie(string title, string genre, int releaseYear, int duration)
        {
            Title = title; 
            Genre = genre;
            ReleaseYear = releaseYear;
            Duration = duration;
        }

        public override string ToString()
        {
            return $"{Id}\t{Title}\t{Genre}\t{ReleaseYear}\t{Duration}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatreManagementSystem
{
    internal class Movie
    {
        // movie class property
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public int Duration { get; set; }

        // constructor for movie class 
        public Movie(string title, string genre, int releaseYear, int duration, int id)
        {
            Title = title; 
            Genre = genre;
            ReleaseYear = releaseYear;
            Duration = duration;
            Id = id;
        }

        // overide tostring method to show info for movie
        public override string ToString()
        {
            return $"{Title, -10}\t{Genre,-10}\t{ReleaseYear,-10}\t{Duration,-10}";
        }
    }
}

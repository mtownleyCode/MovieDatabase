using MovieDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.Data
{
    public class MovieDB
    {
        public List<Movie> movies = new List<Movie>()
        {
            new Movie("The Godfather","drama", 1972),
            new Movie("Raging Bull","sports", 1980),
            new Movie("Citizen Kane","drama", 1941),
            new Movie("Singin' in the Rain","comedy", 1952),
            new Movie("Some Like It Hot","comedy", 1959),
            new Movie("Ben-Hur","Drama", 1959),
            new Movie("Rocky","sports", 1976),
            new Movie("Gladiator","action", 2000),
            new Movie("Raiders of the Lost Ark","action", 1981),
            new Movie("A Streetcar Named Desire","drama", 1951),
        };

    }
}

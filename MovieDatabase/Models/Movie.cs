namespace MovieDatabase.Models
{
    public class Movie
    {
        public int MovieYear { get; set; }

        public string? MovieTitle { get; set; }
        public string? MovieCategory { get; set; }

        public Movie(string title, string? category, int year)
        {
            MovieTitle = title;
            MovieCategory = category;
            MovieYear = year;

        }

    }
}

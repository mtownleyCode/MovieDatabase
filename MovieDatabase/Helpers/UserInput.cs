using MovieDatabase.Data;


namespace MovieDatabase.Helpers
{
    public class UserInput
    {
        public void GetCategory(List<String> categories)
        {
            int validNumber;
                     
            bool redoLoop = true;

            MovieDB movieDB = new MovieDB();

            while (redoLoop)
            {
                Console.WriteLine($"The available movie catogories are:");

                for (int i = 0; i < categories.Count; i++)
                {
                    Console.WriteLine($"{ i + 1 }. { categories[i] }");
                }

                Console.WriteLine();
                Console.WriteLine("Which category ID would you like to view?:");

                if (!int.TryParse(Console.ReadLine(), out validNumber) ||
                   (validNumber <= 0 ||
                    validNumber > categories.Count))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Enter a valid number between 1 and { categories.Count }.");
                    Console.WriteLine();
                    redoLoop = true;
                }
                else
                {
                    Console.WriteLine();

                    Console.WriteLine($"Here is list of the { categories[validNumber - 1] } movies:");

                    var movies = movieDB.movies.OrderBy(t => t.MovieTitle).Where(m => m.MovieCategory == categories[validNumber - 1].ToLower());
                    
                    foreach (var movie in movies)
                    {
                        Console.WriteLine($"{movie.MovieTitle} - { movie.MovieYear }");
                    }

                    Console.WriteLine();
                    redoLoop = false;
                }

            }

        }

        public bool ContinueMovies()
        {
            string validAnswer = "";

            bool redoLoop = true;
            bool moreMovies = false;

            while (redoLoop)
            {
                Console.WriteLine("Do you want to view another category? yes/no");

                validAnswer = Console.ReadLine().ToLower();

                if (validAnswer != "yes" &&
                    validAnswer != "no")
                {
                    Console.WriteLine("Enter yes or no only.");
                    Console.WriteLine();
                    redoLoop = true;
                }

                else
                {
                    if (validAnswer == "yes")
                    {
                        Console.WriteLine();
                        Console.WriteLine("You chose to view more movies.");
                        Console.WriteLine();

                        moreMovies = true;

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Have a nice day. Goodbye.");
                        moreMovies = false;
                    }

                    redoLoop = false;
                }

            }

            return moreMovies;

        }

    }
}

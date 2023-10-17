using MovieDatabase.Helpers;

bool moreMovies = true;

UserInput userInput = new UserInput();

List<string> categories = new List<string>()
{
    "Action",
    "Comedy",
    "Sports"
};

Console.WriteLine("Welcome to the Movie Database App!");

Console.WriteLine();

while (moreMovies)
{
    userInput.GetCategory(categories);

    moreMovies = userInput.ContinueMovies();

}




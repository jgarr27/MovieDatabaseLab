using MovieDatabaseLab;

List<movie> Film = new List<movie>()
{
    //Drama, Sports, Action, Thriller
    new movie("Dances With Wolves", "Drama"),
    new movie("Bull Durham", "Sports"),
    new movie("Message In a Bottle", "Drama"),
    new movie("Waterworld", "Action"),
    new movie("The Postman", "Drama"),
    new movie("Mr Brooks", "Thriller"),
    new movie("Tin Cup", "Sports"),
    new movie("The Highway Men", "Thriller"),
    new movie("Draft Day", "Sports"),
    new movie("The Bodyguard", "Drama"),
    new movie("Field of Dreams", "Drama")
};

Console.WriteLine("Welcome to the Movie List Application! ");
Console.WriteLine();

bool RunProgram = true;
while (RunProgram)
{
    Console.WriteLine("There are 11 movies in this list. ");
    Console.WriteLine("What category are you interested in? ");

    string choice = Console.ReadLine().ToLower().Trim();

    static string ByGenre(List<string, string> movie)
    {
        string choice = movie.First(movie => movie.Contains(choice));
        {
            if(choice == )
        }
    }




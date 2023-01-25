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

    string category = Console.ReadLine().ToLower().Trim();

    List<movie> result = Film.Where(m => m.Genre.ToLower().Trim() == category).ToList();

    Console.WriteLine();
    Console.WriteLine("Here are the matching movies");
    foreach (movie m in result)
    {
        Console.WriteLine($"{m.Title}");
    }
    Console.WriteLine("Whould you like to continue y/n");
    string choice = Console.ReadLine();
    if (choice == "y")
    {
        RunProgram = true;
    }
    else
    {
        RunProgram = false;
    }
}




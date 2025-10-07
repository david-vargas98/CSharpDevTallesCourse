partial class Program
{
    static void Linq()
    {
        // lists to query
        List<int> numbers = [1, 2, 3, 4, 5, 6];
        List<int> evenNumbers = [];

        // going through the numbers list and filtering which are even numbers and then they'll be added to the evenNumbers list:

        // without LINQ:
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
                evenNumbers.Add(number);
        }

        // using LINQ: we have query syntax and method syntax:

        // query syntax
        IEnumerable<int> evenNumbersQuery = from num in numbers
                                            where num % 2 == 0
                                            select num;

        // method syntax
        IEnumerable<int> evenNumbersMethod = numbers.Where(n => n % 2 == 0);

        WriteLine("\n\tQuery Syntax");
        foreach (int number in evenNumbersQuery)
        {
            WriteLine(number);
        }

        WriteLine("\n\tMethod Syntax");
        foreach (int number in evenNumbersMethod)
        {
            WriteLine(number);
        }

        // Marvel characters exercises with LINQ
        List<MarvelCharacter> characters = new List<MarvelCharacter>
        {
            new MarvelCharacter { Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
            new MarvelCharacter { Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
            new MarvelCharacter { Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" },
            new MarvelCharacter { Name = "Natasha Romanoff", Alias = "Black Widow", Team = "Avengers" },
            new MarvelCharacter { Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
            new MarvelCharacter { Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
        };

        // get all characters that belongs to the "Avengers" team
        WriteLine("\n\tCharacters that belong to the Avengers team - Query syntax");
        IEnumerable<string> avengersQuery = from avenger in characters
                                            where avenger.Team == "Avengers"
                                            select $"{avenger.Name} - {avenger.Alias}";
        ShowCharacters(avengersQuery);

        WriteLine("\n\tCharacters that belong to the Avengers team - Method syntax");
        IEnumerable<string> avengersMethod = characters
                                            .Where(avenger => avenger.Team == "Avengers")
                                            .Select(avenger => $"{avenger.Name} - {avenger.Alias}");
        ShowCharacters(avengersMethod);

        // converting all names into uppercase
        WriteLine("\n\tUpper case names");
        var upperCaseNamesQuery = from c in characters
                                  select c.Name?.ToUpper();
        ShowCharacters(upperCaseNamesQuery);

        WriteLine("\n\tUpper case names");
        var upperCaseNamesMethod = characters.Select(character => character.Name?.ToUpper());
        ShowCharacters(upperCaseNamesMethod!);

        // sorting by using the character names
        WriteLine("\nOrdering by name using query syntax");
        IEnumerable<string> sortedQuery = from character in characters
                                          orderby character.Name descending
                                          select character.Name;
        foreach (string characterName in sortedQuery)
        {
            WriteLine(characterName);
        }

        WriteLine("\nOrdering by name using query syntax");
        IEnumerable<MarvelCharacter> sortedMethod = characters
                                           .OrderByDescending(c => c.Name);
        foreach (MarvelCharacter character in sortedMethod)
        {
            WriteLine(character.Name);
        }

        // getting first 3 elements
        WriteLine("\nFirst three elements using Query syntax");
        IEnumerable<MarvelCharacter> firstThreeQuery = (from character in characters
                                                        select character).Take(3);
        foreach (MarvelCharacter character in firstThreeQuery)
        {
            WriteLine(character.Name);
        }

        WriteLine("\nFirst three elements using Method syntax");
        IEnumerable<MarvelCharacter> firstThreeMethod = characters.Take(3);
        foreach (MarvelCharacter character in firstThreeMethod)
        {
            WriteLine(character.Name);
        }

        // getting the first record
        WriteLine("\nFirst element using Query syntax");
        MarvelCharacter firstElementQuery = (from character in characters
                                             select character).First();
        WriteLine(firstElementQuery.Name);

        WriteLine("\nFirst element using Method syntax");
        MarvelCharacter firstElementMethod = characters.First();
        WriteLine(firstElementMethod.Name);
    }

    private static void ShowCharacters(IEnumerable<string> characterQuery)
    {
        foreach (string character in characterQuery)
        {
            WriteLine(character);
        }
    }

    class MarvelCharacter
    {
        public string? Name { get; set; }
        public string? Alias { get; set; }
        public string? Team { get; set; }
    }
}
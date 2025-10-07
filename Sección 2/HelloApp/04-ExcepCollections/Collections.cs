partial class Program
{
    static void Collections()
    {
        // --------------- LISTS
        WriteLine("\tLists");

        // Initialization
        List<string> names = ["Luis", "Pedro", "Pablo"];

        // adding one element
        names.Add("Ana");

        // going through the list
        WriteLine("\nShowing list elements:");
        ShowNames(names);

        // removing element
        names.Remove("Luis");
        WriteLine("\nAfter removing Luis:");
        ShowNames(names);

        // -------------- DICTIONARY
        WriteLine("\n\tDictionaries");

        // Initialization
        Dictionary<int, string> students = new()
        {
            {1, "Ana"},
            {2, "Carlos"},
            {3, "Pablo"}
        };

        // adding element
        students.Add(4, "Roberto");
        WriteLine("\nShowing dictionary elements:");
        ShowStudents(students);

        // removing element
        students.Remove(1);
        WriteLine("\nAfter removing key 1 - Ana:");
        ShowStudents(students);


        // -------------- HASH-SET
        WriteLine("\n\tHash-Set");

        // Initialization
        HashSet<string> users = ["Luis", "Pedro", "Pablo"];

        // add elements
        users.Add("Melissa");
        users.Add("Maria");

        // trying to add repeated user
        users.Add("Luis");      // the element won't be added

        // going through the elements
        WriteLine("\nShowing Hash-set elements:");
        ShowUsers(users);

        // removing element
        users.Remove("Melissa");
        WriteLine("\nAfter removing Melissa:");
        ShowUsers(users);

    }

    private static void ShowUsers(HashSet<string> users)
    {
        foreach (string user in users)
        {
            WriteLine(user);
        }
    }

    private static void ShowStudents(Dictionary<int, string> students)
    {
        foreach ((int key, string value) in students)
        {
            WriteLine($"Key: {key}, Value: {value}");
        }
    }

    private static void ShowNames(List<string> names)
    {
        foreach (string name in names)
        {
            WriteLine(name);
        }
    }
}
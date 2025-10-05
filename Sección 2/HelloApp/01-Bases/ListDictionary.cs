partial class Program
{
    static void ListDictionary()
    {
        // Lists: useful to store and manipulate ordered collections

        List<string> names = ["Ana", "Carlos", "Juan"]; // Initialization
        names.Add("Lucia");

        Console.WriteLine($"Count: {names.Count}");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        string nameToRemove = "Carlos";

        names.Remove(nameToRemove);
        Console.WriteLine($"\"{nameToRemove}\" was removed.");

        string isPresent = names.Contains(nameToRemove) ? $"\"{nameToRemove}\" is in the list." : $"\"{nameToRemove}\" is not in the list.";

        Console.WriteLine(isPresent);

        // Dictionary: pair key-value
        Dictionary<int, string> students = new()
        {
            {1, "Ana"},
            {2, "Felipe"},
            {3, "Elena"}
        };

        foreach ((int key, string value) in students)
        {
            Console.WriteLine($"Key: {key} - Value: {value}");
        }
    }
}
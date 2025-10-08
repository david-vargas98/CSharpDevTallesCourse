partial class Program
{
    static void ShowStringType()
    {
        string name = "Edgar";
        string message = "Hello " + name;
        string interpolatedMessage = $"Hello {name}";

        Console.WriteLine(message);
        Console.WriteLine(interpolatedMessage);

        Console.WriteLine($"Your name has {name.Length} characters");
        Console.WriteLine($"ToUpper Name: {name.ToUpper()}");
        Console.WriteLine($"ToLower Name: {name.ToLower()}");

        int number = 13;
        Console.WriteLine($"Number: {number} - {number.GetType()} was converted to {number.ToString()} - {number.ToString().GetType()}");
    }
}
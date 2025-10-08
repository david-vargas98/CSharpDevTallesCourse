partial class Program
{
    static void HandleNullables()
    {
        // no nullable variable
        string firstName = "Edgar";

        // nullable variable
        string? lastName = null;

        Console.WriteLine($"First Name: {firstName}");

        if (lastName != null)
        {
            Console.WriteLine($"Last Name: {lastName}");
        }
        else
        {
            Console.WriteLine("Last Name was not specified.");
        }

        // null-coalescing operator "??": helps us to avoid writing an if-else sentence
        Console.WriteLine($"Last Name: {lastName ?? "was not specified"}");

        // Safe navigation operator "?.": helps us to keep the execution of the program
        string? text = null;
        Console.WriteLine(text?.Length);
    }
}
partial class Program
{
    static void Variables()
    {
        Console.WriteLine("Variables");

        int age = 10;
        string name = "Edgar";
        bool isStudent = true;

        Console.WriteLine($"{name} is {age} years old, is he/she student?: {isStudent}");
    }
}
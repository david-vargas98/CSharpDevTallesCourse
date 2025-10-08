partial class Program
{
    static void Operators()
    {
        int number = 15;
        bool isEven = number % 2 == 0;
        bool isGreaterThanTen = number > 10;

        if (isEven && isGreaterThanTen)
        {
            Console.WriteLine($"The number {number} is even and greater than ten.");
        }
        else if (!isEven && isGreaterThanTen)
        {
            Console.WriteLine($"The number {number} is odd and greater than ten.");
        }
        else
        {
            Console.WriteLine($"The number {number} is odd and less than ten.");
        }

        // Ternary operator "?:": simplifies the syntax for writing conditional statements
        int age = 21;
        string category = age >= 18 ? "Adult" : "Minor";
        Console.WriteLine(category);
    }
}
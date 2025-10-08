partial class Program
{
    static void AnonymousFunctions()
    {
        WriteLine("Function using delegates:");
        WriteLine(Square(5));

        WriteLine("\nFunction using lambda expressions:");
        WriteLine(LambdaSquare(10));

        // Use of LINQ (lambda expression):
        List<int> numbers = [1, 2, 3, 4, 5, 6];
        IEnumerable<int> evenNumbers = numbers.Where(n => n % 2 == 0);

        WriteLine("\nEven numbers using LINQ:");
        foreach (int even in evenNumbers)
        {
            WriteLine(even);
        }
    }

    static Func<int, int> Square = delegate (int number)
    {
        return number * number;
    };

    // another way to write the previous function (js/lambda like expression)
    static Func<int, int> LambdaSquare = (number) => number * number;
}
partial class Program
{
    static void Tuples()
    {
        // There are 2 ways to define a tuple -> 1. Using Tuple key word, -> 2. Using parenthesis (DataType, DataType)
        (int, string) myTuple = (42, "Hey!");
        WriteLine($"Number: {myTuple.Item1} - Text: {myTuple.Item2}");

        (int Number, string Text) = (23, "Another text!");
        WriteLine($"Number: {Number} - Text: {Text}");

        // we get a tuple by calling the Operations function
        (int sum, int sub) = Operations(4, 5);
        WriteLine($"Sum: {sum}, sub: {sub}");

        // we can use a variable instead of destructuring the values
        var tuple = Operations(5, 4);
        WriteLine($"Sum: {tuple.sum}, sub: {tuple.subtraction}");
    }

    // declaring a method which returns a tuple
    static (int sum, int subtraction) Operations(int a, int b)
    {
        return (a + b, a - b);
    }
}
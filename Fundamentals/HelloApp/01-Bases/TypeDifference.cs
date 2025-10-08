partial class Program
{
    static void TypeDifference()
    {
        // Value type: primitive type variables
        int x = 5;
        int y = x;
        y = 15;
        System.Console.WriteLine($"x: {x}, y: {y}"); // both values are NOT the same

        // ref type: objects, arrays, lists
        Person personOne = new() { Name = "Edgar" };
        Person personTwo = personOne;
        personTwo.Name = "David";

        Console.WriteLine($"personOne: {personOne.Name}, personTwo: {personTwo.Name}"); // both values are the same
    }
        class Person {
            public string? Name { get; set; }
        }
}
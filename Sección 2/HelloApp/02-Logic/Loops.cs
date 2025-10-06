partial class Program
{
    static void Loops()
    {
        // while loop: while the condition is true, the look will be executed
        WriteLine("While");
        int counter = 1;
        while (counter <= 5)
        {
            WriteLine($"Iteration: {counter}");
            counter++;
        }

        // Do while loop: the loop will be executed at least once, since the condition is evaluated after 1st execution
        WriteLine("\nDo While");
        int number = 0;
        do
        {
            WriteLine($"Number: {number}");
            number++;
        } while (number < 3);

        // for loop: we use it when we know how many times it'll be executed
        WriteLine("\nFor");
        for (int i = 0; i <= 5; ++i)
        {
            WriteLine($"Iteration: {i}");
        }

        // custom for
        WriteLine("\nCustom For");
        for (int i = 10; i >= 0; i -= 2)
        {
            WriteLine(i);
        }

        // foreach: we use it to go through collections such as arrays or lists
        WriteLine("\nForeach - Array");
        // Array
        string[] fruits = ["Apple", "Pineapple", "Grape"];
        foreach (string fruit in fruits)
        {
            WriteLine(fruit);
        }

        WriteLine("\nForeach - List");
        List<string> names = ["Edgar", "David", "Carlos", "Pepe"];
        foreach (string name in names)
        {
            WriteLine(name);
        }
    }
}
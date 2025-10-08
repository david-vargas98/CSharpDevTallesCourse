partial class Program
{
    static void Arrays()
    {
        int[] numbers = new int[5];
        numbers[0] = 1; // One way initialize an array value

        // Direct initialization
        int[] numbersArray = [5, 10, 15, 20, 25, 30];

        // Indexes: accessing values
        Console.WriteLine($"First element: {numbersArray[0]}");
        Console.WriteLine($"Third element: {numbersArray[2]}");

        // Length of the array
        Console.WriteLine($"The number of elements is: {numbersArray.Length}");

        // Using "^" to get elements from the end of the array:
        Console.WriteLine($"The last element is: {numbersArray[^1]}"); // last element
        Console.WriteLine($"The last element is: {numbersArray[^2]}"); // penultimate element

        // Getting sub-arrays:
        int[] firstThree = numbersArray[..3]; // first three elements
        int[] fromIndexTwo = numbersArray[2..]; // from index 2 to the end

        Console.WriteLine($"\tFirst three:");
        foreach (int number in firstThree)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine($"\n\tFrom index two:");
        foreach (int number in fromIndexTwo)
        {
            Console.WriteLine(number);
        }
    }
}
partial class Program
{
    static void PrintMultiplicationTable(int number, int tableLimit = 10)
    {
        WriteLine($"The multiplication table of {number} ranging from 1 to {tableLimit} is:");
        for (int i = 1; i <= tableLimit; i++)
        {
            WriteLine($"{number}x{i}={number * i}");
        }
    }

    // Homework:
    static void PrintFactorialTable(int number)
    {
        WriteLine($"The factorial of {number} from 1 to {number} is: "); //5x4x3x2x1 = 120
        int factorialNumber = 1;
        for (int i = 1; i <= number; i++)
        {
            factorialNumber *= i;
            WriteLine($"{i}! = {factorialNumber}");
        }
    }
}
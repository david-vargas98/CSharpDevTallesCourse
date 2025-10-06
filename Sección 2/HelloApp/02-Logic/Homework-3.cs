partial class Program
{
    static void FizzBuzz()
    {
        int stop = 100;

        for (int i = 1; i <= stop; ++i)
        {
            if (i % 3 == 0 && i % 5 == 0)
                WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                WriteLine("Fizz");
            else if (i % 5 == 0)
                WriteLine("Buzz");
            else
                WriteLine(i);
        }
    }
}
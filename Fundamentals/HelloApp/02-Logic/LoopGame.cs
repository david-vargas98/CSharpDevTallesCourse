partial class Program
{
    static void LoopGame()
    {
        int counter = 0;
        WriteLine(" Press any key to increase the counter");
        WriteLine(" Press ESC key to exit the game.\n");

        while (true)
        {
            var key = ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                WriteLine($"Number of times you've pressed the keys before exit the game: {counter}");
                WriteLine("The program has ended.");
                break;
            }
            counter++;
        }
    }
}
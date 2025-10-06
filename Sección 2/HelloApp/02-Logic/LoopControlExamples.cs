partial class Program
{
    static void LoopControlExamples()
    {
        // break: allows us to exit a loop immediately
        WriteLine("\tBreak");
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
                break;

            WriteLine(i);
        }

        // continue: allows us to skip the current iteration
        WriteLine("\tContinue");
        for (int i = 0; i < 10; i++)
        {
            if (i == 5 || i == 7)
                continue;

            WriteLine(i);
        }

        // return: allows us to exit from the current method
        WriteLine("\tContinue");
        for (int i = 0; i < 10; i++)
        {
            if (i == 3)
                //return; this was commented since it throws us out of the "LoopControlExamples" method and the infinite loop is not executed 

                WriteLine(i);
        }

        // Infinite loop: never ends, it could be done by using a while or a for
        bool whileExecution = false;
        // with while
        while (whileExecution)
        {
            WriteLine("This will be executed forever.");
        }

        // with for
        for (; ; )
        {
            WriteLine("This will be executed forever as well.");
        }
    }
}
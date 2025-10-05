partial class Program
{
    static void Generics()
    {
        string[] names = ["Juan", "Luis"];
        int[] numbers = [1, 2, 3];

        // Console.WriteLine("\tLengths without generics");
        // Console.WriteLine($"Length of the numeric array: {GetIntArrayLength(numbers)}");
        // Console.WriteLine($"Length of the string array: {GetStringArrayLength(names)}");

        // So that we can get rid of the previous methods, and get use of the new one
        Console.WriteLine("\n\tLengths with generic method");
        Console.WriteLine($"Length of the numeric array: {GetArrayLength(numbers)}");
        Console.WriteLine($"Length of the string array: {GetArrayLength(names)}");

        // Generic class:
        Box<int> numberBox = new() { Content = 50 };
        Box<string> stringBox = new() { Content = "Now I'm a text!" };

        Console.WriteLine("\n\t Generic classes");
        Console.WriteLine($"Integer generic class content: {numberBox.Content}");
        Console.WriteLine($"String generic class content: {stringBox.Content}");
    }

    // Methods WITHOUT generics
    static int GetIntArrayLength(int[] arr)
    {
        return arr.Length;
    }
    static int GetStringArrayLength(string[] arr)
    {
        return arr.Length;
    }

    // Methods WITH generics
    static int GetArrayLength<T>(T[] array)
    {
        return array.Length;
    }

    // Generic class
    class Box<T>
    {
        public T? Content { get; set; }
        public void Show()
        {
            Console.WriteLine($"Content: {Content}");
        }
    }
}
partial class Program
{
    static void DataStructures()
    {
        // Class
        User user = new() { Name = "Edgar", Age = 26 };
        user.Greet();

        // Struct
        Point point = new() { X = 30, Y = 20 };
        Console.WriteLine($"Point (X): {point.X}, Point (Y): {point.Y} -----> ({point.X},{point.Y})");

        // Record
        CellPhone cellphone = new("Xiaomi", 2020);
        Console.WriteLine($"My cellphone is a {cellphone.Model}, It was launched in {cellphone.Year}.");
    }

    // Class: for complex objects, stored in heap
    class User
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public void Greet()
        {
            Console.WriteLine($"Hello I'm {Name} and I'm {Age} years old!");
        }
    }

    // Struct: for small objects, stored in stack
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    // Record: for immutable data
    record CellPhone(string Model, int Year);
}
partial class Program
{
    static void Properties()
    {
        Animal animal = new("Forest")
        {
            Species = "Wolf",
            Age = 5
        };
        WriteLine($"Where does it live?: {animal.Habitat}\nWhat animal is it?: {animal.Species}\nIs {animal.Age} years old.\n{animal.Category} is its category");
    }
}

class Animal
{
    public string Species { get; set; } = "Unknown";
    public string Category { get; set; } = "Vertebrate";
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
                throw new ArgumentException("The age cannot be negative");

            age = value;
        }
    }
    public string Habitat { get; set; }

    // constructor to initialize the Habitat field
    public Animal(string habitat)
    {
        Habitat = habitat;
    }
}
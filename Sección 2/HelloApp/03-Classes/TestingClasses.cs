partial class Program
{
    static void TestingClass()
    {
        // object instantiation using constructor by default
        Vehicle toyota = new()
        {
            Brand = "Toyota",
            Model = "Corolla",
            Year = 2021
        };
        toyota.ShowInfo();

        Vehicle honda = new()
        {
            Brand = "Honda",
            Model = "Civic",
            Year = 2019
        };
        honda.ShowInfo();

        // instantiation using parameterized constructor
        Vehicle renault = new("Renault", "Duster", 2024);
        renault.ShowInfo();
    }
}

class Vehicle
{
    // properties
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }

    // constructor by default
    public Vehicle(){}

    // parameterized constructor
    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    // methods
    public void ShowInfo()
    {
        WriteLine($"This vehicle is the {Model} model, year {Year}.");
    }
}
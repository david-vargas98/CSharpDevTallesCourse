partial class Program
{
    static void ProductSalesDemo()
    {
        // instantiation
        Inventory inventory = new();

        Product laptop = new()
        {
            Name = "Laptop",
            Price = 1200.99,
            Stock = 5
        };
        Product mouse = new()
        {
            Name = "Mouse",
            Price = 100,
            Stock = 10
        };

        // adding products to inventory
        inventory.AddProduct(laptop);
        inventory.AddProduct(mouse);

        // show inventory
        inventory.ShowInventory();

        // make a sell
        laptop.Sell(1);

        // show inventory again
        inventory.ShowInventory();
    }

    class Product
    {
        // properties
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        // constructors
        public Product() { }
        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        // methods
        public void ShowInfo()
        {
            WriteLine($"Product: {Name}, Price: {Price}, Stock: {Stock}");
        }

        public bool Sell(int quantity)
        {
            if (quantity <= Stock)
            {
                Stock -= quantity;
                WriteLine($"The sale has been successful. {quantity} unit(s) of {Name} were sold.");
                return true;
            }

            WriteLine($"Insufficient stock for {Name}.");
            return false;
        }
    }

    class Inventory
    {
        // properties
        private List<Product> products = [];

        // methods
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void ShowInventory()
        {
            WriteLine("\tProduct inventory");
            foreach (Product product in products)
            {
                product.ShowInfo();
            }
        }
    }

    // exercise:
    static void BusFleet()
    {
        // ------- Exercise:
        WriteLine("\n\tExercise");
        Bus busOne = new("Mercedes", "M-01", 2009, 450_000.50, 0);
        Bus busTwo = new("Mercedes", "M-02", 2010, 500_500.50, 0);
        Bus busThree = new("Mercedes", "M-03", 2012, 550_800.99, 0);
        Fleet fleet = new();

        WriteLine("Adding busses to the fleet...");
        fleet.AddBusToFleet(busOne);
        fleet.AddBusToFleet(busTwo);
        fleet.AddBusToFleet(busThree);
        WriteLine("\n...All Busses were added to the fleet...");

        WriteLine("\n\tFleet details");
        fleet.ShowBuses();
        WriteLine("\n\tAdding conduction to the buses...");
        busOne.Drive(5);
        busTwo.Drive(20);
        busThree.Drive(44);
        WriteLine("\nConduction is finished");
        WriteLine("\n\tFleet details updated");
        fleet.ShowBuses();
    }
    class Bus
    {
        // properties
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public double TotalKilometers { get; set; }

        // constructor
        public Bus(string brand, string model, int year, double price, double totalKilometers)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
            TotalKilometers = totalKilometers;
        }

        // methods
        public void Drive(int kilometers)
        {
            TotalKilometers += kilometers;
            WriteLine($"{kilometers} kilometers were increased to the {Model} model from {Brand} brand. Total kilometers: {TotalKilometers}");
        }

        public void ShowPrice()
        {
            WriteLine($"The bus price is: {Price}");
        }
    }

    class Fleet
    {
        private List<Bus> buses = [];

        // methods
        public void AddBusToFleet(Bus bus)
        {
            buses.Add(bus);
            WriteLine("The bus was added to the fleet!");
        }

        public void ShowBuses()
        {
            foreach (Bus bus in buses)
            {
                WriteLine($"Brand: {bus.Brand}, Model: {bus.Model}, Year: {bus.Year}, Price: {bus.Price}, Total kilometers: {bus.TotalKilometers}");
            }
        }
    }
}
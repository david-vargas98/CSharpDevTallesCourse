partial class Program
{
    static void Methods()
    {
        Car car = new()
        {
            Model = "Yaris",
            Year = 2022
        };
        WriteLine(car.ShowInfo());

        car.ShowMessage("Changing the model...");
        car.ChangeModel("Patrol");
        WriteLine(car.ShowInfo());

        Car.GeneralInfo();

        // using constructor
        Car sportsCar = new("Ferrari", 2020);
        WriteLine(sportsCar.ShowInfo());

        // simplified syntax
        Car collectionCar = new(model: "Cadillac", year: 1980);
        WriteLine(collectionCar.ShowInfo());

        // object list
        WriteLine("\n\tCar List:");
        List<Car> cars = new()
        {
            new Car(){Model="Duster", Year=2021},
            new Car(){Model="StepWay", Year=2019},
            new Car(){Model="Capture", Year=2000}
        };

        foreach (Car item in cars)
        {
            WriteLine(item.ShowInfo());
        }
    }

    class Car
    {
        public string? Model { get; set; }
        public int? Year { get; set; }

        // constructor by default
        public Car() { }
        // parameterized constructor
        public Car(string model, int year)
        {
            Model = model;
            Year = year;
        }
        // destructor
        ~Car()
        {
            WriteLine("This is the destructor in execution.");
        }

        public void ChangeModel(string newModel)
        {
            Model = newModel;
        }

        public string ShowInfo()
        {
            return $"Car model: {Model}, Year: {Year}";
        }

        public void ShowMessage() => WriteLine("This is an automobile.");
        public void ShowMessage(string message) => WriteLine(message);
        public static void GeneralInfo()
        {
            WriteLine("The automobile is one of the most used means of transportation on the planet.");
        }
    }
}